using Android; //benodigde header files
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Widget;
using AndroidX.AppCompat.App;
using Plugin.Media;
using System.Drawing;
using System.Net.Sockets;
using System.IO;
using System;
using System.Threading.Tasks;

namespace Shutter_App
{
    [Activity(Label = "Phone Camera", Theme = "@style/AppTheme", MainLauncher = true)] //additional opties zoals android app naam etc.
    public class MainActivity : AppCompatActivity
    {

        Button captureButton;

        ImageView thisImageView;

        readonly string[] permissionGroup = //established de permissions
        {

            Manifest.Permission.ReadExternalStorage,
            Manifest.Permission.WriteExternalStorage,
            Manifest.Permission.Camera
        };

        TcpClient client;
        protected override async void OnCreate(Bundle savedInstanceState) //OnCreate function dat geload wordt wanneer de android app gelaunched wordt
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState); //initializiation code van Xamarin framework

            SetContentView(Resource.Layout.activity_main);

            captureButton = (Button)FindViewById(Resource.Id.captureButton);
            thisImageView = (ImageView)FindViewById(Resource.Id.thisImageView);

            captureButton.Click += CaptureButton_Click;

            RequestPermissions(permissionGroup, 0); //vraagt permission aan de user

            client = new TcpClient();

            string serverIP = "192.168.100.27"/*"10.38.94.120"*/; //IP addressen van de Wi-Fi's waarop de android app getest werd
            int serverPort = 57799; //port number

            try
            {
              
                await client.ConnectAsync(serverIP, serverPort); //probeert de connectie te maken met de Windows app wanneer de Android app load 

            }

            catch (Exception ex) //geen excception handling hier
            {
                
            }

        }
        

        private async void CaptureButton_Click(object sender, System.EventArgs e) //code om de capture button te laten werken
        {
              
            await TakePhotosAndSend(); //functie dat gecalled wordt wanneer capture button gedrukt wordt

        }

        

        private async Task TakePhotosAndSend()
        {
            await CrossMedia.Current.Initialize(); 

            string serverIP = "10.38.94.120"*;
            int serverPort = 57799;

            try
            {
                using (TcpClient client = new TcpClient()) //using statements zodat alles properly disposed na gebruik
                {

                    while (true) //while loop zodat na het drukken van de capture button een keer, de camera automatisch open gaat de opvolgende keren
                    {
                        await client.ConnectAsync(serverIP, serverPort);

                        var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
                        {
                            PhotoSize = Plugin.Media.Abstractions.PhotoSize.Medium,
                            CompressionQuality = 50, //hoeveelheid compression op de gemaakte foto
                            Name = "myimage.jpg",
                            Directory = "sample"
                        });

                        if (file == null)
                        {
                            break;
                        }

                        byte[] imageArray = File.ReadAllBytes(file.Path); //convert de gemaakte foto naar byte arrays en stuurt het naar de Windows applicatie voor verdere processing
                        using (NetworkStream stream = client.GetStream())
                        {
                            await stream.WriteAsync(imageArray, 0, imageArray.Length);
                            await stream.FlushAsync();
                        }

                    }
                }
            }

            catch (Exception ex) //exception handling
                {            
                    client.Close();
                    client = new TcpClient(); 
                }
            finally
            {
                await TakePhotosAndSend();
            }          
        }

        protected override void OnDestroy() //code dat geexecute wordt wanneer de android app geclosed wordt
        {
            client.Close();
            base.OnDestroy();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults) //functie dat gebruikt word om permission te vragen aan de gebruiker
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
 
            

