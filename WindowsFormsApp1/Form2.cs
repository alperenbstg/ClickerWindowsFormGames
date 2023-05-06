using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            EDIP.Visible = false;
        
         
        }

        private void welcomeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          


        }
          int counter = 60;
        private void startButton_Click(object sender, EventArgs e)
        {
           
            if (easy.Checked)
            {

                counter = 60;
                label1.Visible = false;
            }
            else if (medium.Checked)
            {
                counter = 40;
                label1.Visible = false;
            }
            else if (hard.Checked)
            {
                counter = 20;
                label1.Visible = false;

            }
            else
            {
                
                label1.Visible = true;
                label1.Text = "Please Select Any Diffuculty Level";
                label1.Size = new Size(350, 350);
                EDIP.Visible = false;


            }
            EDIP.Visible = true;
            startButton.Enabled = false;
            label1.Visible= false;

            timer1.Tick += new EventHandler(label4_Click);
            timer1.Interval = 1000; // 1 second
            timer1.Start();
            label1.Text = counter.ToString();
            gameOver.Visible= false;    
            lastScore.Visible= false;
            score = 0;
           


        }
            Random r = new Random();
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int x = r.Next(0, this.ClientSize.Width - EDIP.Width);
            int y = r.Next(0, this.ClientSize.Height - EDIP.Height);
            EDIP.Location = new Point(x, y);
        }
        int score;
        int counter2;
        int j = 782;
        int l = 599;
        int gridWeight = 536;
        int gridHeight = 499;
        private void EDIP_Click(object sender, EventArgs e)
        {
            EDIP.Parent = dataGridView2;
            if (counter2 % 10 == 0) { this.Size = new Size(j,l);

                dataGridView2.Size= new Size(gridWeight,gridHeight);
                counter = counter + 10;
                
            
            }
            counter2++;
            j=j+7;
            l=l+7;
            gridWeight = gridWeight + 7;
            gridHeight = gridHeight + 7;

            timer1.Enabled = true;
            Random r = new Random();
            score = score+1;
            label3.Text = "score" + score;
            int x = r.Next(0, this.ClientSize.Width - EDIP.Width);
            int y = r.Next(0, this.ClientSize.Height - EDIP.Height);
            EDIP.Location = new Point(x, y);
          
            int xMax = panel1.Width - (EDIP).Width;
            int yMax = panel1.Height - (EDIP).Height;


            Random rand = new Random();
            x = rand.Next(0, xMax + 1);
            y = rand.Next(0, yMax + 1);


            ((PictureBox)sender).Location = new Point(x, y);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int x = r.Next(0, this.ClientSize.Width - EDIP.Width);
            int y = r.Next(0, this.ClientSize.Height - EDIP.Height);
            EDIP.Location = new Point(x, y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "score" + score;

        }

        private void timeBox_TextChanged(object sender, EventArgs e)
        {
           
            if (counter == 0)

                timer1.Stop();
            label1.Text = counter.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {
          
            
            if (counter != 0) {
                counter--;
            
            
            
            
            }
            else
            {

                EDIP.Visible = false;
                gameOver.Size = new Size(500, 500);
                gameOver.Visible = true;
                lastScore.Size = new Size(400, 400);
                lastScore.Text = "YOUR SCORE IS: " + score.ToString();
                lastScore.Visible = true;
                startButton.Enabled = true;
               // if (hard.Checked) 
               

            }

            label4.Text = counter.ToString();
        }

        private void easy_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void medium_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void hard_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gameOver_Click(object sender, EventArgs e)
        {
        
           
        }

        private void lastScore_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label2.Text ="WELCOME "+ Form1.name;
        }
    }




}
