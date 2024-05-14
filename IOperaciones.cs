using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace EjercicioInterfaces
{
    public interface IOperaciones
    {
        double Area(double radio);
        double Perimetro(double lado);
        double Volumen(double radio, double altura);
        double Longitud(double lado1, double lado2);
        double Diagonal(double lado1, double lado2);
    }
}