// nodige headers 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Id_scanner
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }


        // Methode voor het verwerken van de klik op de "Login" knop
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginButton();
            
        }

        // Inlogfunctionaliteit uitvoeren bij het drukken van Enter-toets of Sign in button 
        private void LoginButton() 
        {
            
            string id = textDocentID.Text; // variabele voor ingevoerde Id 
            string pass = textPassword.Text; // variabele voor de ingevoerde password

            // Controleren of de ingevoerde gegevens juist zijn
            if (id == "admin" && pass == "123")
            {
                UserInterface f = new UserInterface();
                f.Show();// load de UserInterface form bij correcte credentials 
                this.Hide();// sluit deze form 
            } 
            else
            {  // Als de gegevens onjuist zijn, toon een error en maak de velden leeg
                MessageBox.Show("Incorrect Credentials! Try Again");
                textDocentID.Text = ""; // maakt de Docent ID veld leeg
                textPassword.Text = "";// maakt de password veld leeg 
            }
        }

        
        // Methode voor de "Quit" knop
        private void BtnQuit_Click(object sender, EventArgs e)// quitbutton
        {
            this.Close(); // Close the current form
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit(); // Exit the application
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        // Op de key Enter drukken laat je automatisch in signen indien sign in gegevens correct zijn. 
        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                LoginButton(); 
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textDocentID_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //houdt de password geheim met een *
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            
                if (!string.IsNullOrEmpty(textPassword.Text))
                {
                    textPassword.PasswordChar = '*';
                }
                else
                {
                    textPassword.PasswordChar = '\0'; // Set to null to display the text normally
                }
            


        }

        private void textDocentID_Enter(object sender, EventArgs e)
        {
            if (textDocentID.Text == "Docent ID")
            {
                textDocentID.Text = "";
                textDocentID.ForeColor = Color.Black;
            }
        }
        
        private void textDocentID_Leave(object sender, EventArgs e)
        {
            if (textDocentID.Text == "")
            {
                textDocentID.Text = "Docent ID";
                textDocentID.ForeColor = Color.DarkGray;

            }
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
         

            if (textPassword.Text == "Password")
            {
                textPassword.Text = "";
                textPassword.ForeColor = Color.Black;
            }
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
        
            

            if (textPassword.Text == "")
            {
                textPassword.Text = "Password";
                textPassword.ForeColor = Color.DarkGray;

            }

            
        }

        
    }
}
