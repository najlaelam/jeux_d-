using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace New_Appli
{
    public partial class Form1 : Form
    {
        readonly Random r = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( comboBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs.");
            }
            else
            {
                int nbDeATirer = Convert.ToInt32(comboBox1.SelectedItem);

                List<int> resultatDeNombre = new List<int>();
                List<string> resultatDeImage = new List<string>();
                List<int> resultatDeColor = new List<int>();

                while (nbDeATirer != 0)
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

                        var facesNumber = Convert.ToInt32(comboBox2.SelectedItem.ToString());
                        int random = r.Next(1, facesNumber + 1);
                        resultatDeColor.Add(random);

                    }

                    nbDeATirer--;
                }


                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label16.Text = "";

                for (int i = 0; i < resultatDeNombre.Count; i++)
                {
                    switch (i)
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




                Dictionary<int, Color> colors = new Dictionary<int, Color>();
                colors.Add(1, Color.Blue);
                colors.Add(2, Color.Red);
                colors.Add(3, Color.Black);
                colors.Add(4, Color.White);
                colors.Add(5, Color.Green);
                colors.Add(6, Color.Yellow);

                for (int j = 0; j < resultatDeColor.Count; j++)
                {

                    switch (j)
                    {
                        case 0:
                            pictureBox1.BackColor = colors[resultatDeColor[j]];
                            break;
                        case 1:
                            pictureBox2.BackColor = colors[resultatDeColor[j]];
                            break;
                        case 2:
                            pictureBox3.BackColor = colors[resultatDeColor[j]];
                            break;
                        case 3:
                            pictureBox4.BackColor = colors[resultatDeColor[j]];
                            break;
                        case 4:
                            pictureBox5.BackColor = colors[resultatDeColor[j]];
                            break;
                        case 5:
                            pictureBox6.BackColor = colors[resultatDeColor[j]];
                            break;
                    }
                }

            }
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
            if (comboBox2.Text == "" || comboBox1.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Merci de remplir tous les champs.");
            }
            if (textBox1.Text == "")
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

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button_Afficher_Click(object sender, EventArgs e)
        {
           
            if (comboBox4_Chercher_Jeux.Text == "")
            {
                MessageBox.Show("Merci de selectionne le nom du Jeux");
            }
            else
            {

            List<string> resultatDeRecherche = new List<string>();
            string ChercherJeux = comboBox4_Chercher_Jeux.SelectedItem.ToString();

            string req = string.Format("SELECT nombreDe,nombreFace,typeDe FROM groupe WHERE nomGroupe = '" + ChercherJeux + "'");
            SqlCommand cmd = new SqlCommand(req, cn.cnx);
            cn.cnx.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            while (rd.Read())
            {
                if (rd["typeDe"].ToString().Equals("Numero"))
                {
                    label11.Text = rd["nombreDe"].ToString();
                    label12.Text = rd["nombreFace"].ToString();
                }
                else if (rd["typeDe"].ToString() == "Image")
                {
                    for (int j = 0; j < Int32.Parse(rd["nombreDe"].ToString()); j++)
                    {
                        int random = r.Next(1, Convert.ToInt32(rd["nombreFace"].ToString()) + 1);
                        string imagePath = "C:/Users/Dell/Music/dés/de" + random + ".jpg";

                        resultatDeRecherche.Add(imagePath);
                        switch (j)
                        {
                            case 0:
                                pictureBox1.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                            case 1:
                                pictureBox2.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                            case 2:
                                pictureBox3.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                            case 3:
                                pictureBox4.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                            case 4:
                                pictureBox5.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                            case 5:
                                pictureBox6.ImageLocation = resultatDeRecherche[j].ToString();
                                break;
                        }
                    }
                }
                else if (rd["typeDe"].ToString().Equals("Couleur"))
                {
                    Dictionary<int, Color> colors = new Dictionary<int, Color>();
                    colors.Add(1, Color.Blue);
                    colors.Add(2, Color.Red);
                    colors.Add(3, Color.Black);
                    colors.Add(4, Color.White);
                    colors.Add(5, Color.Green);
                    colors.Add(6, Color.Yellow);

                    for (int j = 0; j < Int32.Parse(rd["nombreDe"].ToString()); j++)
                    {
                        var facesNumber = Convert.ToInt32(rd["nombreFace"].ToString());
                        int random = r.Next(1, facesNumber + 1);
                        switch (j)
                        {
                            case 0:
                                pictureBox1.BackColor = colors[random];
                                break;
                            case 1:
                                pictureBox2.BackColor = colors[random];
                                break;
                            case 2:
                                pictureBox3.BackColor = colors[random];
                                break;
                            case 3:
                                pictureBox4.BackColor = colors[random];
                                break;
                            case 4:
                                pictureBox5.BackColor = colors[random];
                                break;
                            case 5:
                                pictureBox6.BackColor = colors[random];
                                break;
                        }
                    }
                
            }
            }
            rd.Close();
            cn.cnx.Close();
            }
        }
    }

}
