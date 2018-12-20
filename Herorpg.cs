//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class Herorpg
//    {
//        public enum HeroMetier { Guerrier, paysans, Mage };
        
            
  

        


//       public string Nom;
//       protected int Pv;
//       protected int Force;
//       protected int Endurance;
//       protected int Taille;

//        public Herorpg(string n)
//        {
//            Equipement[] Inventaire;
//            Nom = n;
//            Inventaire = new Equipement[10];
//            Inventaire[0] = new potion ("Soin", "potion de soin", 1, 2,potion.potiontype.Heal);

            
//        }

        

//        public int Damage(int degats)
//        {
//            Pv -= degats;
//            if(Pv <= 0)
//            {
//                Console.WriteLine("Dead");

//            }
//            return (Pv);
      
        
        

//        }

//        public virtual int Attack()
//        {
//            return 1;
//        }
//        //public static Herorpg whoisthebest(Herorpg h1,Herorpg h2)
//       // {
//           // if (h1.Force > h2.Force)
//           // { return h1;            }
//           // else 
//           // {
//               // return h2;
//            //}
//        //}

//        public static Herorpg witb (Herorpg[] k)
//        {
//            Herorpg Best = k[0];
//                for (int i = 1; i <= k.Length; i++)
//                {
//                    if (Best.Force <= k[i].Force)
//                    {
//                    k[i] = Best; 
                    
                        


//                    }
                   

//                }
//            return Best;
   
          
//        }
            
            
//     }

//}
