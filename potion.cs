using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class potion : Equipement
    
    {
        
        public enum potiontype { Heal,Defense,Attack};
        public potiontype Type;
        private object heal;
        public MainCharacter chara;

        public potion(string name, string Desciption, int x, int y, potiontype t, MainCharacter c) : base(name, Desciption, x, y)
        {
            Type = t;
            chara = c;
        }

        

        public override void Pickup()
        {
        base.Pickup();
        Console.WriteLine("vous avez une nouvelle potion");
        }

        public override void Use()
        {
            base.Use();
            Console.WriteLine("vous avez utilisé une potion");
            chara.Life += 10;
        }

    }
}
