using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Equipement
    {
        public string nom;
        public string Description;
        public float value;
        public float weight;

        public Equipement(String name, String descipt, float v, float w)
        {
            nom = name;
            Description = descipt;
            value = v;
            weight = w;
        }
        public virtual void Pickup()
        {
            Console.WriteLine("vous ramassez :" + nom);
        }
        public virtual void Use()
        {
            Console.WriteLine("Vous utilisez :" + nom);
        }
        public void print()
        {
            //Console.WriteLine(nameof + " : " + Description);
        }

    }
}
