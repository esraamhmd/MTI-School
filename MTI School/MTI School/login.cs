using System;
using System.Drawing;
using System.Windows.Forms;

namespace MTI_School
{
    public partial class login : Form
    {
        private const string CorrectUsername = "admin";
        private const string CorrectPassword = "123";

        public login()
        {
            InitializeComponent();

            textBox2.PasswordChar = '*';

            // Subscribe to the CheckedChanged event of the checkBox1
           checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            SetTextBoxFontSize();
           
        }
        private void SetTextBoxFontSize()
        {
            // Specify the font size (e.g., 14)
            float fontSize = 14;

            
            Font font = new Font(textBox1.Font.FontFamily, fontSize, textBox1.Font.Style);

            
            textBox1.Font = font;
            Font fon = new Font(textBox2.Font.FontFamily, fontSize, textBox1.Font.Style);


            textBox2.Font = font;

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Toggle the password visibility based on the state of the checkbox
            textBox2.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = textBox1.Text;
            string enteredPassword = textBox2.Text;

            // Replace this with your actual authentication logic (e.g., database check).
            if (IsValidUser(enteredUsername, enteredPassword))
            {
                MessageBox.Show("Login successful!");
                MainMenu mainMenuForm = new MainMenu();
                //this.Close();
                mainMenuForm.Show();
                this.Hide();
                // Close the login form

            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }

        private bool IsValidUser(string username, string password)
        {
            // Replace this with actual authentication logic (e.g., database check).
            return username == CorrectUsername && password == CorrectPassword;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
