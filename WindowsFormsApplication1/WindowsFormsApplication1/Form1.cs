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
        int argent = 50;
        int alcool = 0;
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
            progressBarArgent.Value = argent;
            progressBarAlcool.Value = alcool;
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
            actualiserLesVariables();

        }

        private void gratterConso_Click(object sender, EventArgs e)
        {
            //Demander de l'argent
            int gratteConso = _r.Next(10);
            if (gratteConso == 1)
            {
                argent = argent + 2;
                actualiserLesVariables();
            }

            //Temps perdu a gratter
            heure = heure.Add(cinqMin);
            actualiserLesVariables();
        }

        

        private void saucisson_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter un saucssion";
            argent = argent - 3;
            heure = heure.Add(vingtMin);
            actualiserLesVariables();
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
            argent = argent - 1;
            heure = heure.Add(cinqMin);
            actualiserLesVariables();
            cocacola.Visible = false;
            rinceCo.Visible = false;
        }

        private void rinceCo_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter une rince cochon";
            argent = argent - 2;
            heure = heure.Add(vingtCinqMin);
            alcool = alcool + 1;
            actualiserLesVariables();
            cocacola.Visible = false;
            rinceCo.Visible = false;
        }

        private void progressBarArgent_Click(object sender, EventArgs e)
        {
            progressBarArgent.Maximum = 50;
        }

        private void progressBarAlcool_Click(object sender, EventArgs e)
        {
            progressBarAlcool.Maximum = 20;
        }

        private void actualiserLesVariables()
        {
            textBox4.Text = "Heure:  " + heure;
            textBox2.Text = "Argent: " + argent;
            boiteAlcool.Text = "Alcool: " + alcool;
            progressBarArgent.Value = argent;
            progressBarAlcool.Value = alcool;
        }
    }
}
