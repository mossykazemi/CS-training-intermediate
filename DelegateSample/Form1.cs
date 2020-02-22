using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    public partial class Form1 : Form
    {
        Student s1 = new Student("Ali Ahmadi", 12, 30);
        Parent mom = new Parent("Maryam");
        Parent dad = new Parent("Reza");
        Registerar r1 = new Registerar();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            s1.Target -= new GradeChange(mom.Report);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1.Target += new GradeChange(mom.Report);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s1.Target += new GradeChange(dad.Report);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            s1.Target -= new GradeChange(dad.Report);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            s1.Target += new GradeChange(r1.log);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            s1.Target -= new GradeChange(r1.log);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1.RecordClass(Convert.ToDouble(textBox1.Text));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Student s2 = new Student("Mohammad mohamadi", 18, 20);
            s2.RecordClass(Convert.ToDouble(textBox1.Text));
        }
    }
}
