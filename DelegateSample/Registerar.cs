using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateSample
{
    class Registerar
    {
        public void log(double avg)
        {
            string s;
            s = "I am Registrar \n I wil register your Gpa \n and it's: " + avg.ToString();
            MessageBox.Show(s.ToString());
        }
    }
}
