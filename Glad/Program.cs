using Glad.Equipment.Both;
using Glad.Equipment.Defensive;
using Glad.Equipment.Offensive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Glad
{
    class Program
    {
        static void Main(string[] args)
        {
        //CONSTRUCTION DES JOUEURS----------------------------------------------------------------------------------------------------------------------------
            Player firstPlayer = new Player("Grurm", "Jean", "Dubois");
            Player secondPlayer = new Player("Zadin", "Jeanne", "Dutilleul");
            Player thirdPlayer = new Player("Lycan", "Pierre", "Dupont");
            Player fourthPlayer = new Player("Goteka", "Marie", "Martin");

            
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n---------------------------QUE LE TOURNOI COMMENCE !!---------------------------"); // <-- This line is still white on blue.
            Console.ResetColor();

            Thread.Sleep(1800);

            Console.WriteLine("\nVont s'affronter les joueurs suivants: " + firstPlayer.Pseudo + ", " + secondPlayer.Pseudo + ", " + thirdPlayer.Pseudo + " et " + fourthPlayer.Pseudo+"\n");
            
        //CONSTRUCTION DES EQUIPES ET ATTRIBUTION AUX JOUEURS (1équipe/joueur pour ce test)---------------------------------------------------------------------------------------------------
            Team firstTeam = new Team("Seventh Device", "EncoreUneDescription");
            Team secondTeam = new Team("Order of the Imperial", "UneNouvelleDescription");
            Team thirdTeam = new Team("Council of the Blue Threat", "UneDescriptio");
            Team fourthTeam = new Team("Ninja Eagles", "UneDernièreDescription");

            firstTeam.Victories = 0;
            firstTeam.Defeats = 2;
            secondTeam.Victories = 3;
            secondTeam.Defeats = 0;
            thirdTeam.Victories = 8;
            thirdTeam.Defeats = 1;
            fourthTeam.Victories = 2;
            fourthTeam.Defeats = 2;

            firstPlayer.newTeam(firstTeam);
            secondPlayer.newTeam(secondTeam);
            thirdPlayer.newTeam(thirdTeam);
            fourthPlayer.newTeam(fourthTeam);
            
            Console.WriteLine("Le joueur " + firstPlayer.Pseudo + " engage son équipe: "+ firstPlayer.TeamList[0].TeamName);
            Console.WriteLine("Le joueur " + secondPlayer.Pseudo + " engage son équipe: "+ secondPlayer.TeamList[0].TeamName);
            Console.WriteLine("Le joueur " + thirdPlayer.Pseudo + " engage son équipe: "+ thirdPlayer.TeamList[0].TeamName);
            Console.WriteLine("Le joueur " + fourthPlayer.Pseudo + " engage son équipe: "+ fourthPlayer.TeamList[0].TeamName + "\n");
            Console.WriteLine("\n");

            Thread.Sleep(1800);
        //CONSTRUCTION DES GLADIATEURS ET EQUIPEMENTS ET ATTRIBUTION AUX EQUIPES (3gladiateurs/équipe pour ce test)---------------------------------------------------------------------------------------------------

            Gladiator g1 = new Gladiator("Spartacus");
            g1.newEquipment(new Dagger());
            g1.newEquipment(new Shield());

            Gladiator g2 = new Gladiator("Crixus");
            g2.newEquipment(new Helmet());
            g2.newEquipment(new Sword());

            Gladiator g3 = new Gladiator("Marcus");
            g3.newEquipment(new Helmet());
            g3.newEquipment(new Net());

            Gladiator g4 = new Gladiator("Attilius");
            g4.newEquipment(new Net());
            g4.newEquipment(new Helmet());

            Gladiator g5 = new Gladiator("Flamma");
            g5.newEquipment(new Trident());
            g5.newEquipment(new Helmet());

            Gladiator g6 = new Gladiator("Commodus");
            g6.newEquipment(new Sword());
            g6.newEquipment(new Dagger());
            
            Gladiator g7 = new Gladiator("Priscus");
            g7.newEquipment(new Helmet());
            g7.newEquipment(new Spear());

            Gladiator g8 = new Gladiator("Verus");
            g8.newEquipment(new Dagger());
            g8.newEquipment(new Dagger());
            g8.newEquipment(new Helmet());

            Gladiator g9 = new Gladiator("Carpophorus");
            g9.newEquipment(new Dagger());
            g9.newEquipment(new Spear());

            Gladiator g10 = new Gladiator("Glad10");
            g10.newEquipment(new Dagger());
            g10.newEquipment(new Spear());

            Gladiator g11 = new Gladiator("Glad11");
            g11.newEquipment(new Sword());
            g11.newEquipment(new Dagger());

            Gladiator g12 = new Gladiator("Glad12");
            g12.newEquipment(new SmallShield());
            g12.newEquipment(new Dagger());

            firstTeam.NewGladiator(g1);
            firstTeam.NewGladiator(g2);
            firstTeam.NewGladiator(g3);
            secondTeam.NewGladiator(g4);
            secondTeam.NewGladiator(g5);
            secondTeam.NewGladiator(g6);
            thirdTeam.NewGladiator(g7);
            thirdTeam.NewGladiator(g8);
            thirdTeam.NewGladiator(g9);
            fourthTeam.NewGladiator(g10);
            fourthTeam.NewGladiator(g11);
            fourthTeam.NewGladiator(g12);

            Tournament trnmt = new Tournament(firstPlayer, secondPlayer, thirdPlayer, fourthPlayer);
            trnmt.startTournament();

            Console.Read();
        }
    }
}
