using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Defensive
{
    public class SmallShield:AEquipment, IDefense
    {
        public SmallShield()
        {
            this.Name = "Petit bouclier Rond";
            this.ChanceToDefend = 20;
            this.Point = 5;
        }
    }
}
