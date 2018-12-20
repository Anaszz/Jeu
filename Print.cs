using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Print
    {

        public Print(){
            Begin();


        }

        public void Begin()
        {
            Console.WriteLine(@"

                                                                  ____  _     ____  _      _____  _  _____ ____        ____  _     _____ ____  _____ 
                                                                 /   _\/ \ /|/  _ \/ \  /|/__ __\/ \/  __//  __\      /  _ \/ \ /\/  __// ___\/__ __\
                                                                 |  /  | |_||| / \|| |\ ||  / \  | ||  \  |  \/|      | / \|| | |||  \  |    \  / \  
                                                                 |  \__| | ||| |-||| | \||  | |  | ||  /_ |    /      | \_\|| \_/||  /_ \___ |  | |  
                                                                 \____/\_/ \|\_/ \|\_/  \|  \_/  \_/\____\\_/\_\      \____\\____/\____\\____/  \_/  

                                                                                                   _ _.-'`-._ _
                                                                                                  ;.'________'.;
                                                                                       _________n.[____________].n_________
                                                                                      |''_''_''_''||==||==||==||''_''_''_'']
                                                                                      |'''''''''''||..||..||..||'''''''''''|
                                                                                      |LI LI LI LI||LI||LI||LI||LI LI LI LI|
                                                                                      |.. .. .. ..||..||..||..||.. .. .. ..|
                                                                                      |LI LI LI LI||LI||LI||LI||LI LI LI LI|



                                                       Vous incarnez dans cette folle histoire un constructeur en batiment. Votre but sera de construire
                                                   le batiment de vos rêves. Mais cela n'arrivera pas si facilement. Toutes sortes d'épreuves vous attendent
                                                et essaieront de mettre à mal votre projet. Dans cette aventure, vos points de vies representeront le moral du
                                           constructeur. Quand celui-ci tombe à 0. L'ame passionné de constructeur qui est en vous se verra brisée en mille éclats.
                                                                                         Et ce sera alors un GAME OVER.");
        }

        public static void Txt1()
        {
            
            Console.WriteLine(@"




                                                                                               Quel sera ton nom, Héro.");

            
        }

        public static void Txt2(string name)
        {
            Console.Clear();
            Console.WriteLine(@"




                                                                                              Très bien, Bienvenue " + name.ToUpper());
        }

        public static void Menu()
        {
            Console.WriteLine(@"



                                                                                                    Start Game : 1

 
                                                                                                    Load : 2


                                                                                                    A propos : 3
  

                                                                                                    Quit : 4");
    }

        public static void Combat1()
        {
            //Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine (@"                                         




                                                                                       T.'-._..---.._,-'/|
                                                                                       l|'-.  _.v._   (' |
                                                                                       [l /.'_ \; _~'-.`-t
                                                                                       Y ' _(o} _{o)._ ^.|
                                                                                       j  T  ,-<v>-.  T  ]
                                                                                       \  l ( /-^-\ ) !  !
                                                                                        \. \.  '~'  ./  /c-..,__
                                                                                          ^r- .._ .- .-'  `- .  ~'--.
                                                                                           > \.                      \
                                                                                           ]   ^.                     \
                                                                                           3  .  '>            .       Y
                                                                              ,.__.--._   _j   \ ~   .         ;       |
                                                                             (    ~'-._~'^._\   ^.    ^._      I     . l
                                                                              '-._ ___ ~'-,_7    .Z-._   7'   Y      ;  \        _
                                                                                 /'   '~-(r r  _/_--._~-/    /      /,.--^-._   / Y
                                                                                 '-._    ''~~~>-._~]>--^---./____,.^~        ^.^  !
                                                                                     ~--._    '   Y---.                        \./
                                                                                          ~~--._  l_   )                        \
                                                                                                ~-._~~~---._,____..---           \
                                                                                                    ~----'~       \
                                                                                                                   \                                                                ");
        }

        

        public static void Combat2(string nom, int life)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                    
                                                                                                                    
                                                                         Attention ! " + nom.ToUpper() + " vous attaque !!! [ " + life + " PV]" + @"
                                                                       
                                                                        
                                                                       
                                                                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }



        public static void Combat3(string nom, string nom2, int power)
        {

            Console.WriteLine(@"         
" + nom + " essaie de vous aider en portant des charges trop lourdes mais trébuche !");
            Console.WriteLine(@"              
Aie !! Votre matériel de construction s'abime ! " + nom2 + " perd [-" + power + " PV]");
        }




        public static void Combat4(string nom, int life)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(@"
                                                                                                                                                                            " + nom.ToUpper() + " : [" + life + " PV]");
            Console.ForegroundColor = ConsoleColor.White;

        }



        public static void Combat5()
        {
            
            Console.WriteLine(@"


                                                             ----------------       ----------------        ----------------       ----------------
                                                             - Attaquer : 1 -       - Négocier : 2 -        -   Item : 3   -       -   Fuir : 4   -
                                                             ----------------       ----------------        ----------------       ----------------");




           
        }
        public static void Combat6(string nom)
        {

            Console.WriteLine(@"         
" + nom + " retente sa chance !");
            
        }

        public static void Combat7()
        {

            Console.WriteLine(@"






                                                                                                 Combat terminé.");

        }



        public static void Map()
        {
            Console.WriteLine(@"■ ■ ■
                                ■   ■
                                ■ ■ ■ ");







        }
        
        public static void negoc(string boss, int power)
        {
            Console.WriteLine(@"         
" + boss.ToUpper() + " se sent inutile. Il boude dans un coin en griffonant votre précieux matériel.");

            Console.WriteLine(@"         
Vous décidez de lui laisser une autre chance, mais votre précieux matériel ne reviendra pas. COUP CRITIQUE !!! [-" + power + " PV]");
        }

        public static void Obj()
        {

            Console.WriteLine(@"


                                                         ----------------      -----------------------      -----------------------       --------------
                                                         -- Potion : 1 --      -Attaque spéciale : 2-       ----Super Potion : 3---       --Retour : 4--
                                                         ----------------      -----------------------      -----------------------       --------------             ");





        }
        public static void apropos()
        {
            Console.Clear();
            Console.WriteLine(@"


                                                                         ---------------------------  CAPCOM PRESENT  ------------------------------------


                                                                                           Directed by              ANAS DALAL

                                                                                           Produced by              ANAS DALAL

                                                                                           Editor                   ANAS DALAL

                                                                                           Director of Photography  ANAS DALAL

                                                                                           Music by                 ANAS DALAL

                                                                                           Casting                  ANAS DALAL

                                                                                           Visual Effect Producer   ANAS DALAL");
        }

        public static void apropos2()
        {
            
            Console.WriteLine(@"  
                                    ----------------
                                    -- Retour : 1 --
                                    ----------------

                                                                            ");
        }
        public static void Combat11()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                         
                                                                                         '                 '
                                                                                       (    .            .    )  
                                                                                        (    ._..---.._,-'/  )
                                                                                         l| '-.  _.v._   (' |
                                                                                          [l /.'_ \; _~'-.`-t
                                                                                          Y ' _(|} _{|)._ ^.|
                                                                                          j  T  ,-<v>-.  T  ]
                                                                                          \  l ( /-^-\ ) !  !
                                                                                           \. \.  '~'  ./  /c-..,__
                                                                                             ^r- .._ .- .-'  `- .  ~'--.
                                                                                              > \.                      \       )       (
                                                                                              ]   ^.                     \     )   )   (  (
                                                                                              3  .  '>            .       Y        \  /
                                                                                 ,.__.--._   _j   \ ~   .         ;       |         ||
                                                                                (    ~'-._~'^._\   ^.    ^._      I     . l         ||
                                                                                 '-._ ___ ~'-,_7    .Z-._   7'   Y      ;  \        ||_
                                                                                    /'   '~-(r r  _/_--._~-/    /      /,.--^-._   / Y
                                                                                    '-._    ''~~~>-._~]>--^---./____,.^~        ^.^  !
                                                                                        ~--._    '   Y---.                        \./
                                                                                             ~~--._  l_   )                        \
                                                                                                   ~-._~~~---._,____..---           \
                                                                                                       ~----'~       \
                                                                                                                      \                   


                                                                                                                     ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Combat12(string nom, int life)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(@"                                    
                                                                                                                    
                                                                                      " + nom.ToUpper() + " s'enrage !!! [ " + life + " PV]" + @"
                                                                       
                                                                        
                                                                       
                                                                        ");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void Combat13(string nom, string nom2, int power)
        {

            Console.WriteLine(@"         
" + nom + " n'essaiera plus de vous aider.");
            Console.WriteLine(@"              
Aie !! Votre moral en prends un coup ! " + nom2 + " perd [-" + power + " PV]");
        }
    }




   


}
