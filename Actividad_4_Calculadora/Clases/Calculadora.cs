using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4_Calculadora.Clases
{
    public class Calculadora : Interfaces.Calculadora
    {
        public double Dividir(double a, double b)
        {
           return b == 0 ? throw new DivideByZeroException() : a / b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }

        public double Sumar(double a, double b)
        {
          return a + b;
        }
    }
}
