using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Helpers
{
    public static class Util
    {
        public static decimal ObterCDI()
        {
            // Lógica para obter o valor da CDI do último mês         
            return 0.09m;
        }


        public static decimal ObterTaxaBanco()
        {
            // Lógica para obter o valor da TB          
            return 1.08m;
        }
    }
}
