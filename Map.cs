

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Map
    {

        public int Largeur;
        public int Longueur;

        public string Nom;
        public Case[,] Plateau;
        public Case[,] Position;
        public MainCharacter c;


        public Map(int largeur, int longueur)
        {


            Largeur = largeur;
            Longueur = longueur;
            Plateau = new Case[largeur, longueur];
            Position = new Case[largeur, longueur];
            truc(c);

           
         }





        public void truc(MainCharacter chara)
        {
            for (int i = 0; i < Largeur; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < Longueur; j++)
                {

                    if (i == chara.PosX && j == chara.PosY)
                    {
                        Console.WriteLine(chara.Nom);
                    }
                    Console.Write("■ ");

                }

            }

        }
    }

   
    
}
