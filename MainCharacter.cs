using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MainCharacter : Character

    {
        public int PosY;
        public int PosX;

        public MainCharacter(string n, int L, int P, int posx, int posy) : base(n, L, P)
        {
            PosX = posx;
            PosY = posy;
            
            Print.Txt1();
            n = Console.ReadLine();
            Nom = n;
            Print.Txt2(Nom);
        }

        public override int Attack()
        {
            return Power;
        }

        
        
    }
}
