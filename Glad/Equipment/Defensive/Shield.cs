using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Defensive
{
    public class Shield:AEquipment, IDefense
    {
        public Shield()
        {
            this.Name = "Bouclier rectangulaire";
            this.ChanceToDefend = 30;
            this.Point = 8;
        }
    }
}
