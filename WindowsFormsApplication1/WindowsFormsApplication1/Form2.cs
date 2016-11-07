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
    public partial class Form2 : Form
    {
        private static Form2 instance = null;

        public static void Afficher(string name)
        {
            switch (name)
            {
                case "home":
                    instance.userControl1.Visible = true;
                    instance.userControl2.Visible = false;
                    break;
                case "zytho":
                    instance.userControl2.Visible = true;
                    instance.userControl1.Visible = false;
                    break;



            }
          


        }

        public Form2()
        {
            instance = this;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void userControl12_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void userControl21_Load(object sender, EventArgs e)
        {

        }
    }
}
