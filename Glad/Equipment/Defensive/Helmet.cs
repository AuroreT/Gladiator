using Glad.Equipment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Defensive
{
    public class Helmet:AEquipment, IDefense
    {
        public Helmet()
        {
            this.Name = "Casque";
            this.Point = 2;
            this.ChanceToDefend = 10;
        }
    }
}
