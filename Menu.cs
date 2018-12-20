using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Menu 
    {

        // PrintMenu();

        int Ask = AskChoice(1, 4);
     

        public Menu()
        {
           
            switch (Ask)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    Load();
                    break;
                case 3:
                    APropos();
                    break;
                case 4:
                    Quit();
                    break;
            }
        }



        public static void PrintMenu()
        {
            Print.Menu();

        }




        public static int AskChoice(int min, int max)
        {
            
            int result = int.Parse(Console.ReadLine());



            while (result > max || result < min)
            {
                Console.WriteLine("Saisie incorrect. Réessayez.");
                result = int.Parse(Console.ReadLine());
               
            }
            return result;
        }



    

 
        public static void  StartGame()
        {
            
            Map map = new Map(10, 15);
            

        }

        public static void Load()
        {
            StartGame();  
        }

        public static void APropos()
        {
            Console.Clear();
            Print.apropos();
            Print.apropos2();
            int c = int.Parse( Console.ReadLine());
            if(c == 1)
            {
                Console.Clear();
                PrintMenu();
               int Ask = AskChoice(1, 4);
                switch (Ask)
                {
                    case 1:
                        StartGame();
                        break;

                    case 2:
                        Load();
                        break;

                    case 3:
                        APropos();
                        break;

                    case 4:
                        Quit();
                        break;

                }
            }
        }
        public static void Quit()
        {
            Environment.Exit(0);
        }


    }
}
