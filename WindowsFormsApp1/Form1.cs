using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            errorLabel.Visible = false;

        }
        public static string name;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //if this button has clicked we should see Form2
            name = nameTextBox.Text;
           
            if (nameTextBox.Text.Length == 0)
            {
                errorLabel.Visible = true;
            }
            else
            {
                errorLabel.Visible = false;
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            //if the text box is empty show an error
         
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //app will close
            Close();
        }
    }
}
