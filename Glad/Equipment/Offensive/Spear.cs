using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Offensive
{
    public class Spear:AEquipment, IAttack
    {
        public Spear()
        {
            this.Name = "Lance";
            this.ChanceToAttack = 50;
            this.EngageFightPriority = 2;
            this.Point = 7;
        }
    }
}
