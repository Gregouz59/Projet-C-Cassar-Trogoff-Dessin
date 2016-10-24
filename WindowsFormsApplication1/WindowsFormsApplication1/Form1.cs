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
        int argent = 10;
        int alcool = 0;


        public Form1()
        {
            InitializeComponent();
            this.Text = "Projet Bar";
            textBox2.Text = "Argent: " + argent;
            textBox3.Text = "Alcool: " + alcool;
            textBox4.Text = "Heure";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bouton 2";
            pictureBox1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bouton 3";
            pictureBox1.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Bouton 4";
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
    }
}
