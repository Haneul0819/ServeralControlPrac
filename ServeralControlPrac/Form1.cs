using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServeralControlPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Label label = new Label();

            label.Text = "원하는 글자 출력";
            label.Location = new Point(230, 50);
            Controls.Add(label);

            LinkLabel ll = new LinkLabel();
            ll.Text = "구글";
            ll.Location = new Point(230, 80);
            Controls.Add(ll);
            ll.Click += LabelClick;

            CheckBox cb1 = new CheckBox();
            CheckBox cb2 = new CheckBox();
            CheckBox cb3 = new CheckBox();
            Button btn1 = new Button();

            cb1.Location = new Point(10, 10);
            cb2.Location = new Point(10, 40);
            cb3.Location = new Point(10, 70);
            btn1.Location = new Point(10, 100);
            btn1.Size = new Size(110, 30);

            btn1.Name = "combo";
            btn1.Click += ButtonClick;

            cb1.Text = "고구마";
            cb2.Text = "감자";
            cb3.Text = "토마토";
            btn1.Text = "내가 원하는 작물";

            Controls.Add(cb1);
            Controls.Add(cb2);
            Controls.Add(cb3);
            Controls.Add(btn1);

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (var item in Controls)
            {
                if (item is CheckBox)
                {
                    list.Add(((CheckBox)item).Text);
                }
            }
            MessageBox.Show(string.Join(",", list));
        }

        private void LabelClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.co.kr");
        }
    }
}
