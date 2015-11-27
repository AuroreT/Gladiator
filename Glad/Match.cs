using Glad.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad
{
    public class Match
    {
        Team t1ToFight;
        Team t2ToFight;
        Team looserT;
        Team winnerT;
        List<Team> TeamsInTournament;
        int count = 0;

        public Match(List<Team> TeamsInTournament)
        {
            this.TeamsInTournament = TeamsInTournament;
        }

        /*Méthode récupérant les équipes de gladiateurs en lice, 
         *les tri selon leur ratio 
         *les envoie 2 par 2 se battre,
         *incrémente les victoires/défaites de chaque équipe selon leur résultat,
         *renvoie l'équipe gagnante 
        */
        public Team startMatch()
        {
            sortTeamsWithRatio(TeamsInTournament);

            while (count < 3)
            {
                t1ToFight = TeamsInTournament[0];
                t2ToFight = TeamsInTournament[1];

                if(count == 1)
                {
                    t1ToFight = TeamsInTournament[2];
                    t2ToFight = TeamsInTournament[3];
                }
                if(count == 2)
                {
                    if(TeamsInTournament[0].InCourse == true)
                    {
                        t1ToFight = TeamsInTournament[0];
                    }
                    else if (TeamsInTournament[1].InCourse == true)
                    {
                        t1ToFight = TeamsInTournament[1];
                    }
                    if (TeamsInTournament[2].InCourse == true)
                    {
                        t2ToFight = TeamsInTournament[2];
                    }
                    else if (TeamsInTournament[3].InCourse == true)
                    {
                        t2ToFight = TeamsInTournament[3];
                    }
                }

                Fight fight = new Fight(t1ToFight, t2ToFight);
                looserT = fight.teamsFight();
                looserT.InCourse = false;
                count++;
            }

            if (TeamsInTournament[0].InCourse == true && TeamsInTournament[1].InCourse == false && TeamsInTournament[2].InCourse == false && TeamsInTournament[3].InCourse == false)
            {
                winnerT = TeamsInTournament[0];
                TeamsInTournament[0].Victories++;
                TeamsInTournament[1].Defeats++;
                TeamsInTournament[2].Defeats++;
                TeamsInTournament[3].Defeats++;
            }
            else if (TeamsInTournament[0].InCourse == false && TeamsInTournament[1].InCourse == true && TeamsInTournament[2].InCourse == false && TeamsInTournament[3].InCourse == false)
            {
                winnerT = TeamsInTournament[0];
                TeamsInTournament[1].Victories++;
                TeamsInTournament[0].Defeats++;
                TeamsInTournament[2].Defeats++;
                TeamsInTournament[3].Defeats++;
            }
            if (TeamsInTournament[0].InCourse == false && TeamsInTournament[1].InCourse == false && TeamsInTournament[2].InCourse == true && TeamsInTournament[3].InCourse == false)
            {
                winnerT = TeamsInTournament[0];
                TeamsInTournament[2].Victories++;
                TeamsInTournament[1].Defeats++;
                TeamsInTournament[0].Defeats++;
                TeamsInTournament[3].Defeats++;
            }
            if (TeamsInTournament[0].InCourse == false && TeamsInTournament[1].InCourse == false && TeamsInTournament[2].InCourse == false && TeamsInTournament[3].InCourse == true)
            {
                winnerT = TeamsInTournament[0];
                TeamsInTournament[3].Victories++;
                TeamsInTournament[1].Defeats++;
                TeamsInTournament[2].Defeats++;
                TeamsInTournament[0].Defeats++;
            }
            return winnerT;
        }
            
        //Méthode permettant de trier les teams par ratio
        public void sortTeamsWithRatio(List<Team> teamsInTournament)
        {
            int i = 0;

            while (i < teamsInTournament.Count - 1)
            {
                if(teamsInTournament[i].ratioVictories() < teamsInTournament[i+1].ratioVictories())
                {
                    Tools.exchanger<Team>(teamsInTournament, i, i + 1);
                    i = 0;
                }
                else
                { i++; }
            }
        }

        
    }
}
