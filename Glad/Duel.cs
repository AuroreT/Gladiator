using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Glad
{
    public class Duel
    {
        private bool resAttack;
        private bool resDefend;
        private int resEngageToss;
        private Gladiator _winner;
        private Gladiator _looser;
        private Gladiator gladInT1;
        private Gladiator gladInT2;

        public Duel(Gladiator gladInT1, Gladiator gladInT2)
        {
            this.gladInT1 = gladInT1;
            this.gladInT2 = gladInT2;
        }

        public Gladiator Winner
        {
            get { return this._winner; }
            set { this._winner = value; }
        }

        public Gladiator Looser
        {
            get { return this._looser; }
            set {this._looser = value;}
        }


        //Lance le duel de gladiateur et renvoi le gagnant. Sont incrémentés les nb de victoires/défaites de chaque gladiateur
        public Gladiator FightToDeath()
        {
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("\t\tCOMBAT: " + gladInT1.GladiatorName + " VS " + gladInT2.GladiatorName + "\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ResetColor();
            Thread.Sleep(2000);

            while(gladInT1.InCourse == true && gladInT2.InCourse == true)
            {
                if(gladInT1.EquipmentPriority > gladInT2.EquipmentPriority)
                {
                    resAttack = Tools.doOrNot(gladInT1.ChanceToAttack);
                    Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " tente d'attaquer.");
                    if (resAttack == true)
                    {
                        Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " touche.");
                        resDefend = Tools.doOrNot(gladInT2.ChanceToDefend);
                        if (resDefend == false)
                        {
                            gladInT2.InCourse = false;
                            Winner = gladInT1;
                            Looser = gladInT2;

                            Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " meurt.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("VICTOIRE DE " + gladInT1.GladiatorName);
                            Thread.Sleep(1800);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " réussi à parer.");
                        }
                    }
                    else
                    {
                        resAttack = Tools.doOrNot(gladInT2.ChanceToAttack);
                        Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " tente d'attaquer.");
                        if (resAttack == true)
                        {
                            Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " touche.");
                            resDefend = Tools.doOrNot(gladInT1.ChanceToDefend);
                            if (resDefend == false)
                            {
                                gladInT1.InCourse = false;
                                Winner = gladInT2;
                                Looser = gladInT1;

                                Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " meurt.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("VICTOIRE DE " + gladInT2.GladiatorName);
                                Thread.Sleep(1800);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " réussi à parer.");
                            }
                        }
                    }
                }
                else if(gladInT1.EquipmentPriority < gladInT2.EquipmentPriority)
                {
                    resAttack = Tools.doOrNot(gladInT2.ChanceToAttack);
                    Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " tente d'attaquer.");
                    if (resAttack == true)
                    {
                        Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " touche.");
                        resDefend = Tools.doOrNot(gladInT1.ChanceToDefend);
                        if (resDefend == false)
                        {
                            gladInT1.InCourse = false;
                            Winner = gladInT2;
                            Looser = gladInT1;

                            Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " meurt.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("VICTOIRE DE " + gladInT2.GladiatorName);
                            Thread.Sleep(1800);
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " réussi à parer.");
                        }
                    }
                    else
                    {
                        resAttack = Tools.doOrNot(gladInT1.ChanceToAttack);
                        Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " tente d'attaquer.");
                        if (resAttack == true)
                        {
                            Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " touche.");
                            resDefend = Tools.doOrNot(gladInT2.ChanceToDefend);
                            if (resDefend == false)
                            {
                                gladInT2.InCourse = false;
                                Winner = gladInT1;
                                Looser = gladInT2;

                                Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " meurt.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("VICTOIRE DE " + gladInT1.GladiatorName);
                                Thread.Sleep(1800);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " réussi à parer.");
                            }
                        }
                    }
                }
                else if (gladInT1.EquipmentPriority == gladInT2.EquipmentPriority)
                {
                    resEngageToss = Tools.whoEngageFight(1, 2);
                        
                    if (resEngageToss == 1)
                    {
                        resAttack = Tools.doOrNot(gladInT1.ChanceToAttack);
                        Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " tente d'attaquer.");
                        if (resAttack == true)
                        {
                            Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " touche.");
                            resDefend = Tools.doOrNot(gladInT2.ChanceToDefend);
                            if (resDefend == false)
                            {
                                gladInT2.InCourse = false;
                                Winner = gladInT1;
                                Looser = gladInT2;

                                Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " meurt.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("VICTOIRE DE " + gladInT1.GladiatorName);
                                Thread.Sleep(1800);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " réussi à parer.");
                            }
                        }
                        else
                        {
                            resAttack = Tools.doOrNot(gladInT2.ChanceToAttack);
                            Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " tente d'attaquer.");
                            if (resAttack == true)
                            {
                                Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " touche.");
                                resDefend = Tools.doOrNot(gladInT1.ChanceToDefend);
                                if (resDefend == false)
                                {
                                    gladInT1.InCourse = false;
                                    Winner = gladInT2;
                                    Looser = gladInT1;

                                    Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " meurt.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("VICTOIRE DE " + gladInT2.GladiatorName);
                                    Thread.Sleep(1800);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " réussi à parer.");
                                }
                            }
                        }
                    }
                    else
                    {
                        resAttack = Tools.doOrNot(gladInT2.ChanceToAttack);
                        Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " tente d'attaquer.");
                        if (resAttack == true)
                        {
                            Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " touche.");
                            resDefend = Tools.doOrNot(gladInT1.ChanceToDefend);
                            if (resDefend == false)
                            {
                                gladInT1.InCourse = false;
                                Winner = gladInT2;
                                Looser = gladInT1;

                                Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " meurt.");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("VICTOIRE DE " + gladInT2.GladiatorName);
                                Thread.Sleep(1800);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " réussi à parer.");
                            }
                        }
                        else
                        {
                            resAttack = Tools.doOrNot(gladInT1.ChanceToAttack);
                            Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " tente d'attaquer.");
                            if (resAttack == true)
                            {
                                Console.WriteLine("Le gladiateur " + gladInT1.GladiatorName + " touche.");
                                resDefend = Tools.doOrNot(gladInT2.ChanceToDefend);
                                if (resDefend == false)
                                {
                                    gladInT2.InCourse = false;
                                    Winner = gladInT1;
                                    Looser = gladInT2;

                                    Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " meurt.");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("VICTOIRE DE " + gladInT1.GladiatorName);
                                    Thread.Sleep(1800);
                                    Console.ResetColor();
                                }
                                else
                                {
                                    Console.WriteLine("Le gladiateur " + gladInT2.GladiatorName + " réussi à parer.");
                                }
                            }
                        }
                    }
                }
            }

            if(gladInT1.InCourse == true && gladInT2.InCourse == false)
            {
                gladInT1.Victories++;
                gladInT2.Defeats++;
            }
            else if(gladInT2.InCourse == true && gladInT1.InCourse == false)
            {
                gladInT2.Victories++;
                gladInT1.Defeats++;
            }

        return Looser;
        }
    }
}

