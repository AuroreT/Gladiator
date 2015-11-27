using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment
{
    public abstract class AEquipment
    {
        private int _engageFightPriority;
        private string _name;
        private int _point;
        private int _chanceToAttack;
        private int _chanceToDefend;

        public int EngageFightPriority
        {
            get { return this._engageFightPriority; }
            set { this._engageFightPriority = value; }
        }
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }
        public int Point
        {
            get { return this._point; }
            set { this._point = value; }
        }
        public int ChanceToAttack
        {
            get { return this._chanceToAttack; }
            set { this._chanceToAttack = value; }
        }
        public int ChanceToDefend
        {
            get { return this._chanceToDefend; }
            set { this._chanceToDefend = value; }
        }

    }
}
