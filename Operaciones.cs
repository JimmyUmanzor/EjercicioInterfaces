using EjercicioInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Operaciones : IOperaciones
{
    public double Area(double radio)
    {
        return Math.PI * radio * radio; 
    }

    public double Perimetro(double lado)
    {
        return 4 * lado; 
    }

    public double Volumen(double radio, double altura)
    {
        return Math.PI * radio * radio * altura; 
    }

    public double Longitud(double lado1, double lado2)
    {
        return 2 * (lado1 + lado2);
    }

    public double Diagonal(double lado1, double lado2)
    {
        return Math.Sqrt(lado1 * lado1 + lado2 * lado2);
    }

    public void Imprimir(double resultado)
    {
        Console.WriteLine(resultado);
    }
}
