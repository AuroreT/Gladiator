using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Offensive
{
    public class Net:AEquipment, IAttack
    {
        public Net()
        {
            this.Name = "Filet";
            this.ChanceToAttack = 30;
            this.EngageFightPriority = 1;
            this.Point = 3;
        }
    }
}
