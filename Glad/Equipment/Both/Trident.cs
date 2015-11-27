using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Both
{
    public class Trident:AEquipment, IDefense, IAttack
    {
        public Trident()
        {
            this.Name = "Trident";
            this.ChanceToAttack = 40;
            this.ChanceToDefend = 10;
            this.EngageFightPriority = 3;
            this.Point = 7;
        }
    }
}
