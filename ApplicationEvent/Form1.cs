using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationEvent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("button1_Click is running . . .");
        }
        private void func1(object s,EventArgs x)
        {
            MessageBox.Show("Running func 1 . . .");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Click += new EventHandler(func1);
        }
        private void func2(object s,EventArgs x)
        {
            MessageBox.Show("Running Func 2 . . . .\nButton:"+((Button)s).Text);
        }
        private void func3(object s,KeyPressEventArgs x)
        {
            MessageBox.Show("Key press is running . . .\nYou Pressed: "+x.KeyChar.ToString());
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Button b;
            for (int i = 1; i <= 5; i++)
            {
                b = new Button();
                b.Top=(i * 40);
                b.Left = 10;
                b.Text = i.ToString();
                b.Click += new EventHandler(func2);
                b.KeyPress += new KeyPressEventHandler(func3);
                this.Controls.Add(b);
            }
        }
    }
}
