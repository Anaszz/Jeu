using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class salaire
    {
        public string Name;
        public int SalaryH;
        public int Hour;

        public salaire( int S, int H)
        {
            SalaryH = S;
            Hour = H;
        }
        public virtual int calc()
        {
            return SalaryH * Hour;
        
        }
    }
}
