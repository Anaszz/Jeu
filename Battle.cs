using ConsoleApp2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Battle
    {

        MainCharacter chara;
        Boss boss;
        

        public Battle(Boss s, MainCharacter c)
        {


            Console.Clear();
            chara = c;
            boss = s;
            Atk();
            



        }
        public void Atk()
        {

            
            
                Print.Combat1();
                Print.Combat2(boss.Nom, boss.Life);
                while (boss.Life >= 10 && chara.Life > 0)
                {
                    Print.Combat3(boss.Nom.ToUpper(), chara.Nom.ToUpper(), boss.Power);
                    chara.Damage(boss.Power);
                    Print.Combat4(chara.Nom, chara.Life);
                    Console.WriteLine("Que veux-tu faire " + chara.Nom.ToUpper());
                    Print.Combat5();
                    int c = int.Parse(Console.ReadLine());
                    Choice(c);
                    if (boss.Life > 0 && c != 4)
                    {
                        Print.Combat6(boss.Nom);
                    }


                }

            Print.Combat7();
            phase2();
            
        }

        public void Choice(int C)
        {
            switch (C)
            {
                case 1:
                    combat();
                    break;
                case 2:
                    negocier();
                    break;
                case 3:
                    item();
                    break;
                case 4:
                    fuite();
                    break;
            }
        }

        public void Choice2(int C)
        {
            switch (C)
            {
                case 1:
                    combat2();
                    break;
                case 2:
                    negocier2();
                    break;
                case 3:
                    item2();
                    break;
                case 4:
                    fuite();
                    break;
            }
        }

        public void combat()
        {
            Console.Clear();
            boss.Damage(chara.Power);
            if (boss.Life > 0)
            {
                Print.Combat1();
                Print.Combat2(boss.Nom, boss.Life);
            }
            Console.WriteLine("BOOM  " + boss.Nom.ToUpper() + " perd [-" + chara.Power + " PV]");

        }

        public void negocier()
        {
            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat1();
                Print.Combat2(boss.Nom, boss.Life);
            }
            boss.Power += 1;
            chara.Damage(boss.Power);
            Print.negoc(boss.Nom, boss.Power);
            boss.Power -= 1;

        }
        public void item()
        {
            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat1();
                Print.Combat2(boss.Nom, boss.Life);
            }

            Print.Obj();
            int d = int.Parse(Console.ReadLine());

            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat1();
                Print.Combat2(boss.Nom, boss.Life);
            }

            switch (d)
            {
                case 3:
                    Console.WriteLine("Vous regardez un épisode des constructeurs de l'extrême. Vous êtes remontés à bloc !!! [+10 PV]  [+5 ATK]");
                    chara.Life += 10;
                    chara.Power += 5;
                    break;
                case 1:
                    Console.WriteLine("Vous buvez un cola devant un beau coucher de soleil [+5 PV]");
                    chara.Life += 8;
                    break;
                case 2:

                    chara.Life -= 5;
                    chara.Power += 5;
                    boss.Damage(chara.Power);
                    Console.WriteLine("Attaque Spéciale : Lancer de poutre ! Coups Critique !!" + boss.Nom.ToUpper() + " perd [-" + chara.Power + " PV]");
                    chara.Power -= 5;
                    Console.Clear();
                    if (boss.Life > 0)
                    {
                        Print.Combat1();
                        Print.Combat2(boss.Nom, boss.Life);
                    }

                    break;
                case 4:
                    Print.Combat4(chara.Nom, chara.Life);
                    Console.WriteLine("Que veux-tu faire " + chara.Nom.ToUpper());
                    Print.Combat5();
                    int c = int.Parse(Console.ReadLine());
                    Choice(c);
                    break;
            }
        }

            public void combat2()
        {
            Console.Clear();
            boss.Damage(chara.Power);
            if (boss.Life > 0)
            {
                Print.Combat11();
                Print.Combat12(boss.Nom, boss.Life);
            }
            Console.WriteLine("BOOM  " + boss.Nom.ToUpper() + " perd [-" + chara.Power + " PV]");

        }

        public void negocier2()
        {
            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat11();
                Print.Combat12(boss.Nom, boss.Life);
            }
            boss.Power += 5;
            chara.Damage(boss.Power);
            Print.negoc2(boss.Nom, boss.Power);
            boss.Power -= 5;

        }


        public void item2()
        {
            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat11();
                Print.Combat12(boss.Nom, boss.Life);
            }

            Print.Obj();
            int d = int.Parse(Console.ReadLine());

            Console.Clear();
            if (boss.Life > 0)
            {
                Print.Combat11();
                Print.Combat12(boss.Nom, boss.Life);
            }

            switch (d)
            {
                case 3:
                    Console.WriteLine("Vous regardez un épisode des constructeurs de l'extrême. Vous êtes remontés à bloc !!! [+10 PV]  [+5 ATK]" );
                    chara.Life += 13;
                    chara.Power += 5;
                    break;
                case 1:
                    Console.WriteLine("Vous buvez un cola devant un beau coucher de soleil [+5 PV]");
                    chara.Life += 8;
                    break;
                case 2:
                    
                    chara.Life -= 2;
                    chara.Power += 5;
                    boss.Damage(chara.Power);
                    Console.WriteLine("Attaque Spéciale : Lancer de poutre ! Coups Critique !!" + boss.Nom.ToUpper() + " perd [-" + chara.Power + " PV]");
                    chara.Power -= 5;
                    Console.Clear();
                    if (boss.Life > 0)
                    {
                        Print.Combat11();
                        Print.Combat12(boss.Nom, boss.Life);
                    }
                    break;
                case 4:
                    Print.Combat4(chara.Nom, chara.Life);
                    Console.WriteLine("Que veux-tu faire " + chara.Nom.ToUpper());
                    Print.Combat5();
                    int c = int.Parse(Console.ReadLine());
                    Choice(c);
                    break;
            }
            
        }

        public void fuite()
        {
            Console.Clear();
            Console.WriteLine("Vous prenez la fuite...");
            
        }

        public void phase2()
        {
            if (boss.Life < 10)
            {
                boss.Power += 4;
                Console.Clear();
                Print.Combat11();
                Print.Combat12(boss.Nom, boss.Life);
                while (boss.Life > 0 && chara.Life > 0)
                {
                    Print.Combat13(boss.Nom.ToUpper(), chara.Nom.ToUpper(), boss.Power);
                    chara.Damage(boss.Power);
                    Print.Combat4(chara.Nom, chara.Life);
                    Console.WriteLine("Que veux-tu faire " + chara.Nom.ToUpper());
                    Print.Combat5();
                    int c = int.Parse(Console.ReadLine());
                    Choice2(c);
                    if (boss.Life > 0 && c != 4)
                    {
                        Print.Combat6(boss.Nom);
                    }

                }
            }
        }


    }
}
