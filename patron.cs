using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class patron : salaire
    {
        int Bonus;
        public patron(int S, int H, int b) : base(S, H)
        {
            Bonus = b;
        }

        public override int calc()
        {
            return base.calc() + Bonus;
        }
    }
}
