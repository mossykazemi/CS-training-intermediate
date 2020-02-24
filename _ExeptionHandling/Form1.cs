using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExeptionHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0, z = 0;
            
            try
            {
                x = Convert.ToInt16(textBox1.Text);
                y = Convert.ToInt16(textBox2.Text);
                z = x / y;
            }
            catch(DivideByZeroException err)
            {
                MessageBox.Show("Error \nMessage: "+err.Message+"\nStack trace: "+err.StackTrace+"\nTaget site: "+err.TargetSite);
            }
            catch (FormatException err)
            {
                MessageBox.Show("Error \nMessage: "+err.Message+"\nStack trace: "+err.StackTrace+"\nTaget site: "+err.TargetSite);
            }
            label1.Text = x.ToString() + "/" + y.ToString() + "=" + z.ToString();

        }
    }
}
