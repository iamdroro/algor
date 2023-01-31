using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
namespace WinFormsApp12
{
    class Student
    {
        public string name;
       public  int rost;
        private double  ves=50;
        public double GE()
        {
            return ves;
        }
        public void eda(double ew)
        {
            ves += (ew * 1000 - 1600) / 1000;
        }
    }
}
