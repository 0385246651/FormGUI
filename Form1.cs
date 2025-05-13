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
            loadLabel();
        }

        // thêm label khi mới load lên form
        void loadLabel()
        {
            Label lb = new Label();
            lb.Text = "Loading ...";
            //this bằng vs class hiện tại
            this.Controls.Add(lb);

            lb.BackColor = Color.Aqua;
        }


        int i = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            MessageBox.Show("Bạn đã click BTN " + i + " lần!");
        }


        private void fMain_Click(object sender, EventArgs e)
        {
            label1.Text = "Raiden WF" + " good";
        }

        // khi click label thì sẽ mở form 2
        private void label1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            // show nhiều window của form2 
            //nhưng chỉ có thể show 1 dialog form 2
            f.Show();
            //f.ShowDialog();
            //thay đổi text label ở form 2
            f.lb2.Text = "Share to be better!";
        }

        int j = 0;

        void AddButton()
        {
            Random rand = new Random();
            Button btn = new Button() {
                Text = j.ToString(),
                BackColor = Color.White,
                Location=  new Point(rand.Next(0,this.Size.Width), 
                rand.Next(0, this.Size.Height))
            };

            btn.Click += Btn_Click;

            this.Controls.Add(btn);

            j++;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            // ai gửi request đến hàm này thì đó là sender
            Button btn = sender as Button;
            MessageBox.Show(btn.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddButton();
        }
    }
}
