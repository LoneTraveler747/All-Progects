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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var date_end = DateTime.Parse("21-10-2021");
            labelTime.Text = $"{string.Format("{0:dd} дн. {0:hh} ч. {0:mm} м. {0:ss} сек.", date_end - DateTime.Now)} до старта марафона";
        }
    }
}
