using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Offensive
{
    public class Dagger:AEquipment, IAttack
    {
        public Dagger()
        {
            this.Name = "Dague";
            this.ChanceToAttack = 60;
            this.ChanceToDefend = 0;
            this.EngageFightPriority = 5;
            this.Point = 2;
            
        }
    }
}
