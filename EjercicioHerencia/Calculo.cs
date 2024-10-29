using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioHerencia
{
    public class Calculo : Operaciones
    {
       double AreaRectangulo;
       double VolumenCubo;
       double Circunferencia;

        public void RealizarOperaciones(double baseRect, double altura, double lado, double radio)
        {
            AreaRectangulo = AreaRectangulo(baseRect, altura);
            VolumenCubo = VolumenCubo(lado);
            Circunferencia = Circunferencia(radio);
        }

        public void Imprimir()
        {
            Console.WriteLine($"Área del rectángulo: {AreaRectangulo}cm");
            Console.WriteLine($"Volumen del cubo: {VolumenCubo}cm");
            Console.WriteLine($"Longitud de la circunferencia: {Circunferencia}cm");
        }

    }
}
