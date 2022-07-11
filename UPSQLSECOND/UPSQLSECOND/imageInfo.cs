using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPSQLSECOND
{
    public partial class imageInfo : UserControl
    {
        public imageInfo()
        {
            InitializeComponent();
        }

        private string myVar;

        public string MyProperty
        {
            get { return myVar; }
            set { myVar = value; label1.Text = value; }
        }

        private string Var;

        public string MyPropert
        {
            get { return Var; }
            set { Var = value; label2.Text = value; }
        }

        private Image my;

        public Image MyPropertyy
        {
            get { return my; }
            set { my = value; pictureBox1.Image = value; }
        }


        private void imageInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
