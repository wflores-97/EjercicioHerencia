using EjercicioHerencia;

class program { 
    static void Main(string[] args)
    {
       Calculo calculadora = new Calculo();

        // Solicitar datos al usuario
        Console.WriteLine("Ingrese la base del rectángulo en cm:");
        double baseRect = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese la altura del rectángulo en cm:");
        double altura = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el lado del cubo en cm:");
        double lado = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el radio de la circunferencia en cm:");
        double radio = Convert.ToDouble(Console.ReadLine());

        // Realizar operaciones
        calculadora.RealizarOperaciones(baseRect, altura, lado, radio);

        // Imprimir resultados
        calculadora.Imprimir();
    }
}