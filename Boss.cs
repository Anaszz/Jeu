using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Boss : Character
    {
        public Boss(string n, int L, int P) : base(n, L, P)
        {
            Nom = n;
            

        }

        public override int Attack()
        {
            return Power;
        }

    }


}
