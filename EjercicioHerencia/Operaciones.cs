using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Operaciones
    {
        public double AreaRectangulo(double baserect, double altura)
        {
            return baserect * altura;
        }

        public double VolumenCubo(double lado)
        {
            return Math.Pow(lado, 3);
        }

        public double Circunferencia(double radio)
        {
            return 2 * Math.PI * radio;
        }
    }
}
