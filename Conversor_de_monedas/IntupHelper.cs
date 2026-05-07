using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor_de_monedas
{
    internal class IntupHelper
    {
        public static bool LeerEntero(string texto)
        {
            if (double.TryParse(texto, out double valor))
                return true;
            else
                return false;
        }
    }
}
