using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Glad
{
    public class Tournament
    {
        private List<Team> _teamsInTournament;
        Team winnerOfTournament;
        Player p1;
        Player p2;
        Player p3;
        Player p4;

        public List<Team> TeamsInTournament
        {
            get { return this._teamsInTournament; }
            set { this._teamsInTournament = value; }
        }

        public Tournament(params Player[] player)
        {
            TeamsInTournament = new List<Team>();
                        
            foreach(Player plyr in player)
            {
                foreach (Team team in plyr.TeamList)
                {
                    TeamsInTournament.Add(team);
                }
            }
            p1 = player[0];
            p2 = player[1];
            p3 = player[2];
            p4 = player[3];
        }

        //Méthodes envoyant les équipes de gladiateurs en lice au combat et récupérant le gagnant du tournoi
        public void startTournament()
        {
            Match match = new Match(TeamsInTournament);
            winnerOfTournament = match.startMatch();
            Thread.Sleep(2000);
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (p1.TeamList.Contains(winnerOfTournament))
            {
                Console.WriteLine("\n--------------------------------------------------------------------------------");
                Console.WriteLine("Le gagnant du tournoi est: " + p1.Pseudo + " avec son équipe " + winnerOfTournament.TeamName + ".\n\t\t GLOIRE AU CHAMPION " + p1.Pseudo.ToUpper() + " !!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else if (p2.TeamList.Contains(winnerOfTournament))
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Le gagnant du tournoi est: " + p2.Pseudo + " avec son équipe " + winnerOfTournament.TeamName + ".\n\t\t GLOIRE AU CHAMPION " + p2.Pseudo.ToUpper() + " !!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else if (p3.TeamList.Contains(winnerOfTournament))
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Le gagnant du tournoi est: " + p3.Pseudo + " avec son équipe " + winnerOfTournament.TeamName + ".\n\t\t GLOIRE AU CHAMPION " + p3.Pseudo.ToUpper() + " !!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            else if (p4.TeamList.Contains(winnerOfTournament))
            {
                Console.WriteLine("--------------------------------------------------------------------------------");
                Console.WriteLine("Le gagnant du tournoi est: " + p4.Pseudo+ " avec son équipe "+winnerOfTournament.TeamName +".\n\t\t GLOIRE AU CHAMPION "+p4.Pseudo.ToUpper()+" !!");
                Console.WriteLine("--------------------------------------------------------------------------------");
            }
            Console.ResetColor();
            Thread.Sleep(2000);
        }
    }
}

