using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GIP_Wiskunde_Joppe_van_Treek
{
    static class cLooptijdBerekenen
    {
        public static int Berekentijd(int intKeuzeLooptijd, int intLooptijd)
            {
            int retvalue;
            switch (intKeuzeLooptijd)
            {
                case 1:
                    retvalue = intLooptijd/ 3;
                    break;
                case 0:
                    retvalue = intLooptijd / 12;
                    break;
                default:
                    retvalue = intLooptijd;
                    break;
            }
            return retvalue;
            }
    }
}
