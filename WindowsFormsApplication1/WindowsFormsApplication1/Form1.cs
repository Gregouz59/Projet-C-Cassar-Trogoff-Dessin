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

        private void button4_Click_1(object sender, EventArgs e)
        {
            messageForTheUser.Text = "c'est quoi";
        }

        private void poserTable_Click(object sender, EventArgs e)
        {

            messageForTheUser.Text = "Tu es assis à une table avec des copains";
            TimeSpan dixMin = TimeSpan.FromMinutes(10);
            heure = heure.Add(dixMin);
            textBox4.Text = "Heure:  " + heure;
        }

        private void saucission_Click(object sender, EventArgs e)
        {
            messageForTheUser.Text = "Tu viens d'acheter un saucssion";
            argent = argent - 2.5;
            TimeSpan vingtMin = TimeSpan.FromMinutes(20);
            heure = heure.Add(vingtMin);
            textBox4.Text = "Heure:  " + heure;
            textBox2.Text = "Argent: " + argent;
        }
    }
}
