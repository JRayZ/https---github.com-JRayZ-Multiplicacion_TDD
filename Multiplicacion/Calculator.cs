using System;
using System.Collections.Generic;
using System.Text;

namespace Multiplicacion
{
    public class Calculator
    {
        public static int Multiply(int x, int y)
        {
            //return x*y;
            try
            {
                return checked(x * y);
            }
            catch
            {
                
                throw new OverflowException("La multiplicacion que desea realizar sobrepasa los limites de tamaño del entero.");
            }
        }
    }
}
