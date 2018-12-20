using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Character
    {
    public string Nom;
    public int Life;
    public int Power;
    


     public Character(string n, int L, int P)
        {
            Nom = n;
            Life = L;
            Power = P;

        }

      


        public int Damage(int degats)
        {

            Life -= degats;
            if (Life <= 0)
            {
                Console.WriteLine(Nom + " a perdu tout ses PV");

            }
            return (Life);

        }


            

         public virtual int Attack()
            {
                
                return Power;
            }

        }
}
