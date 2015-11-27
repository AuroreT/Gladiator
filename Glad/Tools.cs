using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glad
{
    public static class Tools
    {
        //Méthode permettant d'échanger la position de 2 éléments dans une liste
        public static void exchanger<T>(this List<T> l, int firstIndex, int secondIndex)
        {
            T t = l[firstIndex];
            l[firstIndex] = l[secondIndex];
            l[secondIndex] = t;
        }

        //Méthode permettant de définir si le gladiateur touche/défend ou non
        public static bool doOrNot(Double chanceTo)
        {
            bool result;

            Random rand = new Random();

            double value = rand.Next(0, 3);
            if (value < chanceTo/100)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }

        public static int whoEngageFight(int nb1, int nb2)
        {
            int result;

            Random random = new Random();
            result = random.Next(nb1, nb2);

            return result;
        }
    }
}
