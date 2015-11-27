using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Offensive
{
    public class Sword:AEquipment, IAttack
    {
        public Sword()
        {
            this.Name = "Epée";
            this.ChanceToAttack = 70;
            this.EngageFightPriority = 4;
            this.Point = 8;
        }
    }
}
