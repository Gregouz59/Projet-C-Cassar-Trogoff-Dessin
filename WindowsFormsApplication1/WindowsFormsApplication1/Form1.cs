using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        double argent = 10;
        double alcool = 0;
        TimeSpan heure = new TimeSpan(2, 14,0);
        TimeSpan cinqMin = TimeSpan.FromMinutes(5);
        TimeSpan vingtMin = TimeSpan.FromMinutes(20);
        TimeSpan dixMin = TimeSpan.FromMinutes(10);
        TimeSpan vingtCinqMin = TimeSpan.FromMinutes(25);

        static Random _r = new Random();
       


        public Form1()
        {
            InitializeComponent();
            this.Text = "Projet Bar";
            textBox2.Text = "Argent: " + argent;
            boiteAlcool.Text = "Alcool: " + alcool;
            textBox4.Text = "Heure:  " + heure;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "t'es moche";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Bouton 2";
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Bouton 3";
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Bouton 4";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void poserTable_Click(object sender, EventArgs e)
        {

            messageForTheUser.Text = "Tu es assis à une table avec des copains";
            heure = heure.Add(dixMin);
            textBox4.Text = "Heure:  " + heure;
        
        }

        private void gratterConso_Click(object sender, EventArgs e)
        {
            //Demander de l'argent
            int gratteConso = _r.Next(10);
            if (gratteConso == 1)
            {
                argent = argent + 2;
                textBox2.Text = "Argent: " + argent;
            }

            //Temps perdu a gratter
            heure = heure.Add(cinqMin);
            textBox4.Text = "Heure:  " + heure;
        }


      
        

        private void saucisson_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter un saucssion";
            argent = argent - 2.5;
            heure = heure.Add(vingtMin);
            textBox4.Text = "Heure:  " + heure;
            textBox2.Text = "Argent: " + argent;
        }

        private void allerAuBar_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Que veux tu consommer ?";
            cocacola.Visible = true;
            rinceCo.Visible = true;
        }

        private void cocacola_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter un coca";
            argent = argent - 0.8;
            heure = heure.Add(cinqMin);
            textBox4.Text = "Heure:  " + heure;
            textBox2.Text = "Argent: " + argent;
            cocacola.Visible = false;
            rinceCo.Visible = false;
        }

        private void rinceCo_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter une rince cochon";
            argent = argent - 2;
            heure = heure.Add(vingtCinqMin);
            alcool = alcool + 1;
            textBox4.Text = "Heure:  " + heure;
            textBox2.Text = "Argent: " + argent;
            boiteAlcool.Text = "Alcool: " + alcool;
            cocacola.Visible = false;
            rinceCo.Visible = false;
        }
    }
}
