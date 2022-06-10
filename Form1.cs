using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace New_Appli
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        
        
        DataSet da;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nbDeATirer = Convert.ToInt32(comboBox1.SelectedItem);
            
            List<int> resultatDeNombre = new List<int>();
            List<string> resultatDeImage = new List<string>();
            List<string> resultatDeColor = new List<string>();
            

            while(nbDeATirer != 0)
            {
                if (comboBox3.SelectedItem.ToString() == "Image")
                {
                    
                    int random = r.Next(1, Convert.ToInt32(comboBox2.SelectedItem.ToString()) + 1); 
                    string imagePath = "C:/Users/Dell/Music/dés/de" + random + ".jpg"; 
                   
                    resultatDeImage.Add(imagePath);
                }
                


                if (comboBox3.SelectedItem.ToString() == "Numero")
                {
                    int random = r.Next(1, Convert.ToInt32(comboBox2.SelectedItem.ToString()) + 1);
                    resultatDeNombre.Add(random);
                }

                
                if (comboBox3.SelectedItem.ToString() == "Couleur")
                {
                    int random = r.Next(0,Convert.ToInt32(comboBox2.SelectedItem.ToString()) + 1);
                    pictureBox1.BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
                    
                }

                nbDeATirer--;
            }


            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";



            for (int i=0; i < resultatDeNombre.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        label11.Text = resultatDeNombre[i].ToString();

                        break;
                    case 1:
                        label12.Text = resultatDeNombre[i].ToString();
                        
                        break;
                    case 2:
                        label13.Text = resultatDeNombre[i].ToString();
                        break;
                    case 3:
                        label14.Text = resultatDeNombre[i].ToString();
                        break;
                    case 4:
                        label15.Text = resultatDeNombre[i].ToString();
                        break;
                    case 5:
                        label16.Text = resultatDeNombre[i].ToString();
                        break;
                }
            }
            pictureBox1.ImageLocation = "";
            pictureBox2.ImageLocation = "";
            pictureBox3.ImageLocation = "";
            pictureBox4.ImageLocation = "";
            pictureBox5.ImageLocation = "";
            pictureBox6.ImageLocation = "";

            for (int j = 0; j < resultatDeImage.Count; j++)
            {
                switch (j)
                {
                    case 0:
                        pictureBox1.ImageLocation = resultatDeImage[j].ToString();

                        break;
                    case 1:
                        pictureBox2.ImageLocation = resultatDeImage[j].ToString();

                        break;
                    case 2:
                        pictureBox3.ImageLocation = resultatDeImage[j].ToString();
                        break;
                    case 3:
                        pictureBox4.ImageLocation = resultatDeImage[j].ToString();
                        break;
                    case 4:
                        pictureBox5.ImageLocation = resultatDeImage[j].ToString();
                        break;
                    case 5:
                        pictureBox6.ImageLocation = resultatDeImage[j].ToString();
                        break;
                }
            }

            string ChercherJeux = comboBox4_Chercher_Jeux.SelectedItem.ToString();
            
            
            string req = string.Format("SELECT nombreDe,nombreFace,typeDe FROM groupe WHERE nomGroupe = " + ChercherJeux + "");
            
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string req = string.Format("select nomGroupe from groupe");
            SqlCommand cmd = new SqlCommand(req, cn.cnx);
            cn.cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                comboBox4_Chercher_Jeux.Items.Add(rd["nomGroupe"]);
            }
            rd.Close();
            cn.cnx.Close();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && comboBox2.Text == "" && comboBox1.Text == "" && comboBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs.");


            }
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Merci de saisir le nom du Jeux");


            }
            else
            {


                string req = string.Format("insert into groupe values  ('" + textBox1.Text + "'," + comboBox1.SelectedItem.ToString() + "," + comboBox2.SelectedItem.ToString() + ",'" + comboBox3.SelectedItem.ToString() + "')");
                SqlCommand cd = new SqlCommand(req, cn.cnx);
                cn.cnx.Open();
                cd.ExecuteNonQuery();
                cn.cnx.Close();
                MessageBox.Show("Saved");
                




            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_Chercher_Jeux_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
