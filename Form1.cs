using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormGUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

        }

        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            MessageBox.Show("Bạn đã click BTN " + i + " lần!");
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
