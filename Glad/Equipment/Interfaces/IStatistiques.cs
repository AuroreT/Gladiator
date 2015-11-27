using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad.Equipment.Interfaces
{
    public interface IStatistiques
    {
        int Victories { get; set; }
        int Defeats { get; set; }

        double ratioVictories();
    }
}
