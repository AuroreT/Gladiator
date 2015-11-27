using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad
{
    public class Player
    {
        private string _lastName;
        private string _firstName;
        private string _pseudo;
        private DateTime _inscriptionDate;
        private List<Team> _teamList = new List<Team>();
        private int teamNumberMaximumByPlayer = 5;
        private bool _winnerPlayer = false;

        
        //Construction du joueur avec son pseudo, noms et date d'inscription(par défaut maintenant)
        public Player(string pseudo, string fName, string LName)
        {
            this.Pseudo = pseudo;
            this.FirstName = fName;
            this.LastName = LName;
            this.InscriptionDate = DateTime.Now;
        }

        public string LastName
        {
            get { return this._lastName; }
            set { this._lastName = value; }
        }

        public string FirstName
        {
            get { return this._firstName; }
            set { this._firstName = value; }
        }

        public string Pseudo
        {
            get { return this._pseudo; }
            set { this._pseudo = value; }
        }

        public DateTime InscriptionDate
        {
            get { return this._inscriptionDate; }
            set { this._inscriptionDate = value; }
        }

        public List<Team> TeamList
        {
            get { return this._teamList; }
            set { this._teamList = value; }
        }

        public bool WinnerPlayer
        {
            get { return this._winnerPlayer; }
            set { _winnerPlayer = value; }
        }

        //Méthode prévoyant l'insertion d'une équipe si le quotat maximum/joueur n'est pas atteint
        public void newTeam(Team t)
        {
            if (this.TeamList.Count < teamNumberMaximumByPlayer){this.TeamList.Add(t);}
            else {Console.WriteLine("Nombre maximum d'équipes atteint");}
            
        }

        public void deleteTeam(Team t)
        {
            this.TeamList.Remove(t);
        }
    }
}
