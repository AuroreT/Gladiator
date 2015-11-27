using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Glad
{
    public class Fight
    {
        Gladiator gladInT1;
        Gladiator gladInT2;
        Gladiator looser;
        Team t1;
        Team t2;
        Team looserTeam;
        Team winnerTeam;

        public Fight(Team t1, Team t2)
        {
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--------------------------------------------------------------------------------");
            Console.WriteLine("Affrontement équipes: " + t1.TeamName + " VS " + t2.TeamName + "\n");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.ResetColor();
            Thread.Sleep(2000);

            this.t1 = t1;
            this.t2 = t2;
        }

        //Méthode envoyant les gladiateurs se battre en duel 2 par deux et renvoi l'équipe perdante
        public Team teamsFight()
        {
            t1.GladiatorList[0].InCourse = true;
            t2.GladiatorList[0].InCourse = true;
            t1.GladiatorList[1].InCourse = true;
            t2.GladiatorList[1].InCourse = true;
            t1.GladiatorList[2].InCourse = true;
            t2.GladiatorList[2].InCourse = true;

            while (t1.GladiatorList[2].InCourse == true && t2.GladiatorList[2].InCourse == true)
            {
                gladInT1 = t1.GladiatorList[0];
                gladInT2 = t2.GladiatorList[0];

                if (t1.GladiatorList[0].InCourse == false)
                {
                    gladInT1 = t1.GladiatorList[1];
                }
                if (t1.GladiatorList[1].InCourse == false)
                {
                    gladInT1 = t1.GladiatorList[2];
                }

                if (t2.GladiatorList[0].InCourse == false)
                {
                    gladInT2 = t2.GladiatorList[1];
                }
                if (t2.GladiatorList[1].InCourse == false)
                {
                    gladInT2 = t2.GladiatorList[2];
                }

                Duel duel = new Duel(gladInT1, gladInT2);
                looser = duel.FightToDeath();
                looser.InCourse = false;
            }

            if (t1.GladiatorList[2].InCourse == false && t2.GladiatorList[2].InCourse == true)
            {
                winnerTeam = t1;
                looserTeam = t2;

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + winnerTeam.TeamName + " remporte la manche");
                Console.ResetColor();
                Thread.Sleep(2000);                               
            }
            else if (t1.GladiatorList[2].InCourse == true && t2.GladiatorList[2].InCourse == false)
            {
                winnerTeam = t1;
                looserTeam = t2;

                Thread.Sleep(2000);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + winnerTeam.TeamName + " remporte la manche");
                Console.ResetColor();
                Thread.Sleep(2000);
            }

            return looserTeam;
        }
    }
}
