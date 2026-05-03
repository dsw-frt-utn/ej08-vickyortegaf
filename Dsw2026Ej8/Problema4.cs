using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidadNotas = 0;

            if (nota1 is int n1 && n1 >= 0 && n1 <= 10)
            {
                suma += n1;
                cantidadNotas++;
            }

            if (nota2 is int n2 && n2 >= 0 && n2 <= 10)
            {
                suma += n2;
                cantidadNotas++;
            }

            if (nota3 is int n3 && n3 >= 0 && n3 <= 10)
            {
                suma += n3;
                cantidadNotas++;
            }

            if (cantidadNotas == 0)
            {
                return 0;
            }

            return (double) suma / cantidadNotas;
        }
    }
}
