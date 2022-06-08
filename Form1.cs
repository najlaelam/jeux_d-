using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_Appli
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        int de1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedItem.ToString() == "Image" && comboBox1.SelectedItem.ToString()=="1" && comboBox2.SelectedItem.ToString()=="2")
            {

                
                //Pour Image
                
                switch (de1)
                {
                    case 1:

                        pictureBox1.ImageLocation = "C:/Users/Dell/Music/dés/de1.png";
                        break;
                        
                    case 2:
                        pictureBox1.ImageLocation = "C:/Users/Dell/Music/dés/de2.jfif";

                        break;
                    

                }



            }
            else
            {
                pictureBox1.ImageLocation = null;
            }
            if (comboBox3.SelectedItem.ToString() == "Numero" && comboBox1.SelectedItem.ToString() == "1" && comboBox2.SelectedItem.ToString() == "2")
            {
                
                int random = r.Next(1, 3);
                label6.Text = random.ToString();

            }
            else
            {
                label6.Text = "";
            }
            if (comboBox3.SelectedItem.ToString() == "Couleur" && comboBox1.SelectedItem.ToString() == "1" && comboBox2.SelectedItem.ToString() == "2")
            {
                
                pictureBox1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
            }
            

           
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
