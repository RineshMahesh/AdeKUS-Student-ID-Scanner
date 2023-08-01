
using System; //benodigde headers
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Tesseract;
using System.Diagnostics;
using Microsoft.Scripting.Runtime;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using Microsoft.Scripting.Hosting.Shell;
using Emgu.CV.CvEnum;
using System.Diagnostics.Contracts;
using System.Diagnostics.Eventing.Reader;

namespace Id_scanner
{
    public partial class UserInterface : Form
    {
        private List<string> photoPaths;
        private int currentPhotoIndex;
        private string extractedText;
        private string filePath;
        private string selectedFilePath; 
        private string currentPhotoPath;


        private async void Form_Load(object sender, EventArgs e) //functie dat aangeroepen wordt wanneer de form load
        {
            await InitializeConnectionAsync();

        }

        private async Task InitializeConnectionAsync()
        {
            await ConnectToMobileAppAsync(); //Maakt connectie met Android app

            await Task.Run(async () => await StartListeningForImageAsync()); //Luistert voor inkomende foto's
        }
        public UserInterface()
        {
            InitializeComponent();
            this.Load += Form_Load;
        }

        private void btnLeave_Click(object sender, EventArgs e) //Quit button van Windows app
        {
            Application.Exit();
        }

        private void btnCreateFile_Click(object sender, EventArgs e) //functie dat wordt geroepen wanneer een attendance list wordt gemaakt
        {
    
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Text Documents|*.txt"; //type file dat gebruikt wordt om attendance list te maken
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;

                    try
                    {
                        using (StreamWriter writer = new StreamWriter(filePath))
                        {
                       
                        }

                        MessageBox.Show("File created"); // pop-up indien attendance list gemaakt is
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while creating the file: " + ex.Message); //exception handling
                    }
                }
            }
        }

        private void AppendTextToFile(string text) //function dat gebruikt wordt om student info op te slaan in attendance list
        {
            
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while appending to the file: " + ex.Message);
            }
        }



        private StreamWriter fileWriter;
        private void CompareData(string CompareText, string AppendText) // function dat gebruikt wordt om te bepalen als een student mag deelnemen aan een tentamen of niet.
        {
            try
            {
                
                string fileContents = File.ReadAllText(selectedFilePath);

                if (!string.IsNullOrEmpty(CompareText) && fileContents.Trim().Contains(CompareText.Trim()))
                {
                    DeniedOrAcceptedBox.Text = " Student accepted";
                    AppendTextToFile(AppendText); //indien student accepted is dan wordt de students info opgeslagen in de attendance list
                } 
                else
                {
                    DeniedOrAcceptedBox.Text = " Student denied"; //indien student denied is dan wordt student info niet opgeslagen in attendance list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while comparing data: " + ex.Message);
            }
        }


        private void BtnMoodleLijst_Click(object sender, EventArgs e) // function dat wordt gebruikt om registration list te selecteren, dat nodig is om een student te verifieren
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Documents|*.txt"; //optie om alleen text files te kunnen selecteren
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedFilePath = openFileDialog.FileName;
               
                MessageBox.Show("File selected"); //pop-up als file geselecteerd is

                if (!File.Exists(selectedFilePath))
                {
                    MessageBox.Show("File does not exist");
                    return;
                }

            }
            
        }

        private string GetMatchValue(string input, string pattern, string afterPattern) // functie dat wordt gebruikt om regex pattern op te stellen (accepteerd drie parameters)
        {
            string fullPattern = pattern + "(.*?)" + Regex.Escape(afterPattern);
            Match match = Regex.Match(input, fullPattern, RegexOptions.Singleline);
            return match.Success ? match.Groups[1].Value.Trim() : null;
        }

        private string GetMatchValue(string input, string pattern) // functie dat wordt gebruikt om regex pattern op te stellen (accepteerd twee parameters)
        {
            Match match = Regex.Match(input, pattern);
            return match.Success ? match.Groups[1].Value : null;
        }

        private void pictureBoxFotoDisplayen_Click(object sender, EventArgs e) 
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void UserInterface_Load(object sender, EventArgs e)
        {
        }
        private void GivesFuncOfPicBox_Click(object sender, EventArgs e)
        {
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void StudentStatus_Click(object sender, EventArgs e)
        {

        }

        private void DeniedOrAcceptedBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnPhotoFolderSelect_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void UpdateRichTextBox(string message) // textbox waarin phone status displayed word (connected of disconnected)
        {
            if (richTextBox1.InvokeRequired)
            {
              
                richTextBox1.Invoke(new Action<string>(UpdateRichTextBox), message);
            }
            else
            {
                
                richTextBox1.AppendText(message);
                richTextBox1.AppendText(Environment.NewLine);
            }
        }

        private TcpListener listener;
        private TcpClient client;

            private async Task ConnectToMobileAppAsync() //function dat luistert naar inkomende connecties en probeert te connecten aan Android app
            {
         
            int listenPort = 57799; //willekeurige port number
            
                try
                {

                    if (listener != null) //indien listener niet 0 is dan moet listener gestopt worden
                    {
                        listener.Stop();
                        listener = null;
                    }

                    if (client != null) //indien client niet 0 is dan moet client gestopt worden
                    {
                        client.Close();
                        client.Dispose();
                        client = null;
                    }
            
                    listener = new TcpListener(IPAddress.Any, listenPort);
                    listener.Start(); //listener wordt gestart

                    client = await listener.AcceptTcpClientAsync();

                    if (client != null || client.Connected) // als er een connectie met Android app dan komt de onderstaande pop-up
                    {
                        MessageBox.Show("Phone connected to PC");
                        UpdateRichTextBox(" Connected"); //textbox wordt geupdate als er connectie is
                    
                    } else if (client == null || !client.Connected) { //als er geen connectie is dan komt de onderstaande pop-up
                        
                    MessageBox.Show("Phone disconnected from PC");
                        UpdateRichTextBox(" Disconnected"); //textbox wordt geupdate als er geen connectie is

                    }
                
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Server error: " + ex.Message); //exception handling

                }

        }

        private void CloseConnection() //function dat ervoor zorgt dat connection geclosed wordt.
        {
            if (client != null)
            {
                client.Close();
                client.Dispose();
                client = null;
            }

            if (listener != null)
            {
                listener.Stop();
                listener = null;
            }
        }

        public static Mat ApplyGrayscale(Mat img, float contrast) //ocr filter dat grayscale toepast op een foto
        {
            Mat grayImage = new Mat();
            CvInvoke.CvtColor(img, grayImage, Emgu.CV.CvEnum.ColorConversion.Bgr2Gray);
            
            grayImage.ConvertTo(grayImage, grayImage.Depth, contrast, 0);
            
            return grayImage;
        }


        public static Mat ApplyBlur(Mat img1) //ocr filter dat blur toepast op een foto
        {
            Mat blurredImage = new Mat();
            CvInvoke.GaussianBlur(img1, blurredImage, new Size(5, 5), 0);
            return blurredImage;
        }

        public static Mat ApplyThreshold(Mat img2) //ocr filter dat treshold toepast op een foto
        {
            Mat thresholdImage = new Mat();
            CvInvoke.Threshold(img2, thresholdImage, 100, 200, ThresholdType.Binary | ThresholdType.Otsu);
            return thresholdImage;
        }

        public static System.Drawing.Image ConvertMatToImage(Mat img3) //convert mat type naar bitmap(image) zodat het displayed kan worden in picturebox wanneer gewenst
        {
            Image<Bgr, byte> image = img3.ToImage<Bgr, byte>();
            return image.ToBitmap();
        }


        private byte[] BitmapToBytes(Bitmap bitmap) //convert bitmap naar byte array
        {
            using (MemoryStream stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Bmp);
                return stream.ToArray();
            }
        }



        private void HandleReceivedImage(byte[] imageArray) //deze functie voert wat handelingen uit op de ontvangen foto
        {

            if (string.IsNullOrEmpty(filePath) || !File.Exists(filePath)) //eerst checken als user attendance list gemaakt heeft voor het scannen
            {
                MessageBox.Show("Please create an attendance list before scanning.");
                
                if (string.IsNullOrEmpty(selectedFilePath)) //ook checken als user registration list select heeft voor het scannen
                {
                    MessageBox.Show("Please select a registration list before scanning.");
                    return;
                }

                return;

                
            } else
            {


                if (string.IsNullOrEmpty(selectedFilePath)) //als user attendance list heeft gemaakt en registration list niet dan komt onderstaande pop-up
                {
                    MessageBox.Show("Please select a registration list before scanning.");
                    return;
                }


            }

            string tempoImagePath = Path.Combine(Path.GetTempPath(), "ontvangImage.jpg"); //maakt een temporary file
            
            try {
                
                    File.WriteAllBytes(tempoImagePath, imageArray); 

                    using (Image ontvangImage = Image.FromFile(tempoImagePath)) //gebruik van using statements zodat alles properly disposed word na gebruik
                    { 

                        Mat image_2 = CvInvoke.Imread(tempoImagePath, ImreadModes.Color); //emgu.cv call om een foto te readen

                        Mat grayImage = ApplyGrayscale(image_2, 2.0f); //applied grayscale aan de foto
                        Mat blurImage = ApplyBlur(grayImage); //applied blur
                        Mat tresholdImage = ApplyThreshold(blurImage); //applied treshold
                        System.Drawing.Image ocr_img = ConvertMatToImage(grayImage); //convert final foto van mat naar image format

                        pictureBoxFotoDisplayen.Image = ontvangImage; //ontvangen foto van android app displayen in picturebox

                        using (var tesseract = new TesseractEngine(@"C:\Program Files\Tesseract-OCR\tessdata", "nld")) //tesseract engine loaden
                        {
                            using (var image = Pix.LoadFromMemory(BitmapToBytes((Bitmap)ocr_img)))
                            {
                                using (var page = tesseract.Process(image))
                                {
                                    string tesseractText = page.GetText(); // ocr toepassen
                                    extractedText = Regex.Replace(tesseractText, @"\s+", " "); //extra characters en spaties uitfilteren

                                    string voornaam = GetMatchValue(extractedText, @"Voornaam\s+(\w+)"); //filters om alleen de gewenste parameters te displayen
                                    string naam = GetMatchValue(extractedText, @"Naam\s+(\w+)");
                                    string studierichting = GetMatchValue(extractedText, @"ANTON DE KOM UNIVERSITEIT VAN SURINAME", @"2021-2022");
                                    string studNr = GetMatchValue(extractedText, @"Stud\. Nr\.\s+(\d+)");


                                    string formattedText = $" Voornaam: {voornaam}\n"; //formaat waarin de parameters gedisplayed zullen worden
                                    formattedText += $" Naam: {naam}\n";
                                    formattedText += $" Studierichting: {studierichting}\n";
                                    formattedText += $" Stud.Nr: {studNr}\n";

                                   Invoke(new Action(() => //runt op een andere thread
                                    {
                                        if (studNr != null) //als studentennummer een waarde heeft dan voer de onderstaande uit
                                        {
                                             richTextBox2.Text = formattedText; //display student informatie in textbox
                                             CompareData(studNr, formattedText); //studentennummer verifieren met registration list om te bepalen als student accepted of student denied

                                        } else // als studentennummer geen waarde heeft voer de onderstaande uit
                                        {
                                            pictureBoxFotoDisplayen.Image = null; //picturebox leeg maken
                                            richTextBox2.Text = null; //richtextbox leeg maken
                                            DeniedOrAcceptedBox.Text = null; //deniedacceptedtextbox leeg maken
                                            MessageBox.Show("Scan failed! Try again"); //pop-up dat wijst om opnieuw te scannen 

                                        }
                                        
                                        
                                        
                                    }));
                                }
                            }
                        }
                    }

                } 
            
                catch (Exception ex)
                {
                    MessageBox.Show("Could not receive image: " + ex.Message);

                }
                finally
                {
                    if (File.Exists(tempoImagePath)) //delete de temporary file als het bestaat
                    {
                        File.Delete(tempoImagePath);
                    }
                }   

            File.Delete(tempoImagePath);
        }


        private async Task StartListeningForImageAsync() //luister for inkomende connecties
        {
            try
            {
                while (true)
                {
                    
                    using (TcpClient client = await listener.AcceptTcpClientAsync())
                    {
                        
                        Debug.WriteLine("Client connected: " + client.Connected); //debug lines
                        await HandleImageAsync(client);
                        Debug.WriteLine("Client disconnected: " + client.Connected);
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while receiving image: " + ex.Message);
            }
        }

        private async Task HandleImageAsync(TcpClient client) //ontvangt de image
        {
            
            using (NetworkStream stream = client.GetStream())
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    int bytesRead;
                    byte[] buffer = new byte[client.ReceiveBufferSize];

                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0) //loop om de hele image te ontvangen in de best mogelijke kwaliteit
                    {
                        await memoryStream.WriteAsync(buffer, 0, bytesRead);
                    }

                    byte[] imageArray = memoryStream.ToArray();
                    HandleReceivedImage(imageArray); //imagearray wordt passed in handlereceivedimage function voor verdere processing

                    Array.Clear(buffer, 0, buffer.Length); //maakt de buffer leeg zodat er geen conflicten staan bij het ontvangen en handlen van andere foto's
                    memoryStream.SetLength(0);
                    memoryStream.Position = 0;
                }
            }
        }


        private void StopListening() //function dat de listener en client stopt wanneer geroepen
        {
            if (listener != null)
            {
                listener.Stop();
                listener = null;
            }

            if (client != null)
            {
                client.Close();
                client = null;
            }
        }
      
    }

}
