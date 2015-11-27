using Glad.Equipment;
using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad
{
    public class Gladiator:IStatistiques
    {
        private int _countEquipmentMaxPoint = 10;
        private int _countEquipmentPoint;
        private string _gladiatorName;
        private double _chanceToDefend;
        private double _chanceToAttak;
        private bool _inCourse = true;
        private int _equipmentPriority;
        private int _victories;
        private int _defeats;
        private double _ratioVictories;
        private List<AEquipment> _equipmentList;

        public int CountEquipmentMaxPoint
        {
            get { return this._countEquipmentMaxPoint; }
            set { this._countEquipmentMaxPoint = value; }
        }

        public int CountEquipmentPoint
        {
            get { return this._countEquipmentPoint; }
            set { this._countEquipmentPoint = value; }
        }

        public string GladiatorName
        {
            get { return this._gladiatorName; }
            set { _gladiatorName = value; }
        }

        public double ChanceToDefend
        {
            get { return this._chanceToDefend; }
            set { this._chanceToDefend = value; }
        }

        public double ChanceToAttack
        {
            get { return this._chanceToAttak; }
            set { this._chanceToAttak = value; }
        }
        public bool InCourse
        {
            get { return this._inCourse; }
            set { this._inCourse = value; }
        }

        public int EquipmentPriority
        {
            get { return this._equipmentPriority; }
            set { this._equipmentPriority = value; }
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

        public double RatioVictories
        {
            get { return this._ratioVictories; }
            set { this._ratioVictories = value; }
        }

        public List<AEquipment> EquipmentList
        {
            get { return this._equipmentList; }
            set { _equipmentList = value; }
        }

        //Constructeur
        public Gladiator (string n)
        {
            this.GladiatorName = n;
            this.EquipmentList = new List<AEquipment>();
            this.CountEquipmentPoint = 0;
                        
        }

        //Ajout d'un équipement si le nombre de point max le permet
        public void newEquipment(AEquipment e)
        {
            int countEquipPoint = e.Point;

            if ((countEquipPoint + this.CountEquipmentPoint) < CountEquipmentMaxPoint+1)
            {
                this.EquipmentList.Add(e);
                this.CountEquipmentPoint = this.CountEquipmentPoint + countEquipPoint;
                if (e is IDefense)
                {
                    this.ChanceToDefend = ChanceToDefend+e.ChanceToDefend;
                }
                else if(e is IAttack)
                {
                    this.ChanceToAttack = ChanceToAttack+e.ChanceToAttack;
                }
                else
                {
                    this.ChanceToDefend = ChanceToDefend + e.ChanceToDefend;
                    this.ChanceToAttack = ChanceToAttack+e.ChanceToAttack;
                }
            }
            else
            {
                Console.WriteLine("Tu portes trop d'équipement "+GladiatorName+" !");
            }          
        }

        public void deleteEquipment(AEquipment e)
        {
            this.EquipmentList.Remove(e);
        }


        public void sortEquipPriority(List<AEquipment>itemList)
        {
            int i = 0;

            if(itemList.Count > 1)
            {
                while(i < itemList.Count - 1)
                {
                    if(itemList[i].EngageFightPriority < itemList[i+1].EngageFightPriority)
                    {
                        Tools.exchanger<AEquipment>(itemList, i, i + 1);
                        i = 0;
                    }
                    else { i++; }
                }
            }
        }

        public double ratioVictories()
        {
            throw new NotImplementedException();
        }
    }
}