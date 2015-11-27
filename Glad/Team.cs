using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad
{
    public class Team:IStatistiques
    {
        private string _teamName;
        private string _teamDescription;
        private List<Gladiator> _gladiatorsList = new List<Gladiator>();
        private int gladiatorNumberMaximumByTeam = 3;
        private int _victories = 0;
        private int _defeats = 0;
        private bool _inCourse = true;

        public Team(string name, string descript)
        {
            this.TeamName = name;
            this.TeamDescription = descript;
        }
        
        public string TeamName
        {
            get { return this._teamName; }
            set { this._teamName = value; }
        }

        public string TeamDescription
        {
            get { return this._teamDescription; }
            set { this._teamDescription = value; }
        }

        public int Victories
        {
            get { return this._victories; }
            set { this._victories = value; }
        }

        public int Defeats
        {
            get { return this._defeats; }
            set { this._defeats = value; }
        }

        public bool InCourse
        {
            get { return this._inCourse; }
            set { _inCourse = value; }
        }

        public int NbTotalFights()
        {
            return (this.Victories + this.Defeats);
        }
        public double ratioVictories()
        {
            return (this.Victories * 100 / this.NbTotalFights());
        }

        public List<Gladiator> GladiatorList
        {
            get { return this._gladiatorsList; }
        }

        //Méthodes permmettant l'ajout d'un gladiateur et la suppression
        public void NewGladiator(Gladiator g)
        {
            if (this.GladiatorList.Count < gladiatorNumberMaximumByTeam)
            {
                this.GladiatorList.Add(g);
            }
            else { Console.WriteLine("Nombre maximum de gladiateurs atteint"); }
        }

        public void deleteGladiator(Gladiator g)
        {
            this.GladiatorList.Remove(g);
        }
    }
}
