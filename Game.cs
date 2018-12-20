using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Game
    {
        //public Player player;
        //public Map plateau;

        Print story;
        MainCharacter chara;
        Boss boss;
        Battle battle;
        Menu menu;


        public Game()
        {
            story = new Print();
            chara = new MainCharacter("", 12, 2, 1, 1);
            Menu.PrintMenu();
            StartGame();
            //boss = new Boss("Petit chat maladroit", 18, 1);
            //Battle(boss, chara);

        }

        public void StartGame()
        {
            
             menu = new Menu();
            
        }


        public void Deplacement()
        {
            //PrintChoix();
            
            //int choix = Menu.AskChoice(0, 4);
            //TODO RECUPERER LA CASE
            // TODO Tester le contenu de la case
            //TODO Peut être lancer un combat...
        }


        public void Battle(Boss b, MainCharacter m)
        {

          battle = new Battle( b , m);     
          
        }


    }
}
