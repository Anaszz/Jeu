using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Case1
    {

        public enum CaseType { Desert, Plaine, Lac, Foret };

        public int X;
        public int Y;
        public CaseType Type;
        public string Description;
        public Boss B;
        public Equipement Item;
        public MainCharacter chara;
        public potion potion;
       

        public Case1(int x, int y, CaseType t, string D)
        {
            
            X = x;
            Y = y;
           
            Type = t;
            Description = D;
            
            //Hero = null;
            //Random r = new Random(DateTime.Now.Millisecond);
            //if (r.Next() % 100 > 50)
            //{
            //    Item = new potion("Soin", "Potion de soin", 1, 2, potion.potiontype.Heal);
            //    Console.WriteLine("vous avez une nouvelle potion");
            //}
            //else
            //    Console.WriteLine("Ah gros, c'est la crise là. Marche encore un peu");
            Item = null;
            
            Console.WriteLine(D);

        }

    }
}
