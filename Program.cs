using EjercicioInterfaces;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese el radio del círculo           :");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el lado del cuadrado           :");
        double ladoCuadrado = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el radio del cilindro          :");
        double radioCilindro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la altura del cilindro         :");
        double alturaCilindro = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el primer lado del rectángulo  :");
        double lado1Rectangulo = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo lado del rectángulo :");
        double lado2Rectangulo = Convert.ToDouble(Console.ReadLine());


        Operaciones operaciones = new Operaciones();

        Console.WriteLine("***************RESULTADOS***************");

        Console.Write("El área del círculo es         :");
        operaciones.Imprimir(operaciones.Area(radio));

        Console.Write("El perímetro del cuadrado es   :");
        operaciones.Imprimir(operaciones.Perimetro(ladoCuadrado));

        Console.Write("El volumen del cilindro es     :");
        operaciones.Imprimir(operaciones.Volumen(radioCilindro, alturaCilindro));

        Console.Write("La longitud del rectángulo es  :");
        operaciones.Imprimir(operaciones.Longitud(lado1Rectangulo, lado2Rectangulo));

        Console.Write("La diagonal del rectángulo es  :");
        operaciones.Imprimir(operaciones.Diagonal(lado1Rectangulo, lado2Rectangulo));

        Console.ReadLine();
    }
}