using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    class Parent
    {
        string fname;
        public Parent(string name)
        {
            fname = name;
        }
        public void Report(double avg)
        {
            string s;
            s = "I am" + fname + "\nOne of Parents" + "\nMy child GPA reported me and is: " + avg.ToString();
            MessageBox.Show(s);
        }
    }
}
