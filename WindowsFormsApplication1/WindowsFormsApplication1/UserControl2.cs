using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class UserControl2 : UserControl
    {
        public string MyProperty { get; set; }

        public UserControl2()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2.Afficher(this.MyProperty);
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
