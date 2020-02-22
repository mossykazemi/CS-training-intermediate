using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateSample
{
    public delegate void GradeChange(double avg);
    class Student
    {
        string fullName;
        double gpa;
        int unit;
        public event GradeChange Target;
        public string FullName
        {
            set
            {
                fullName = value;
            }
            get
            {
                return fullName;
            }
        }
        public Student(string name,double avg,int count)
        {
            FullName = name;
            gpa = avg;
            unit = count;
        }
        public void RecordClass(double grade)
        {
            gpa = (gpa * unit + grade) / (unit + 1);
            unit++;
            if(Target!=null)
            Target(gpa);
        }
    }
}
