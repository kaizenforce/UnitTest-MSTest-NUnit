using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizen_UnitTest
{
    public class Calculadora
    {

        public Calculadora()
        {

        }

        public int Sumar(int numero_1, int numero_2)
        {
            return numero_1 + numero_2;
        }

        public int Restar(int numero_1, int numero_2)
        {
            return numero_1 - numero_2;
        }

        public int Multiplicar(int numero_1, int numero_2)
        {
            return numero_1 * numero_2;
        }

        public int Dividir(int numero_1, int numero_2)
        {
            int resultado = 0;

            if (numero_1 >= numero_2 && numero_1>0 && numero_2 >0 )
            {
                resultado = numero_1 / numero_2;
            }

            return resultado;
        }

    }
}
