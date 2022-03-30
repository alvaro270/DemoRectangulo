using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int P_Ax, P_Ay, P_Bx, P_By, P_Cx, P_Cy, P_Dx, P_Dy;
            Console.WriteLine("COORDENADA DE PUNTO A:");
            Console.WriteLine("Valor de X:");
            //Convert.ToInt32 convierte el texto en un número,
            //por lo que pasar Console.ReadLine convertirá el
            //"valor x" en un numero entero
            P_Ax = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de Y:");
            P_Ay = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Punto A: ({P_Ax},{P_Ay})");

            Console.WriteLine("COORDENADA DE PUNTO B:");
            Console.WriteLine("Valor de X:");
            P_Bx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de Y:");
            P_By = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Punto B: ({P_Bx},{P_By})");

            Console.WriteLine("COORDENADA DE PUNTO C:");
            Console.WriteLine("Valor de X:");
            P_Cx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de Y:");
            P_Cy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Punto C: ({P_Cx},{P_Cy})");

            Console.WriteLine("COORDENADA DE PUNTO D:");
            Console.WriteLine("Valor de X:");
            P_Dx = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor de Y:");
            P_Dy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Punto D: ({P_Dx},{P_Dy})");

            rectangulo Rectangulo = new rectangulo();
            Punto A = new Punto(P_Ax, P_Ay);
            Punto B = new Punto(P_Bx, P_By);
            Punto C = new Punto(P_Cx, P_Cy);
            Punto D = new Punto(P_Dx, P_Dy);

            double perimetro = Rectangulo.Perimetro(A, B, C, D);
            double area = Rectangulo.Area(A, B, C, D);
            Console.WriteLine($"RESULTADOS: ");
            Console.WriteLine($"Perimetro: {perimetro} cm.");
            Console.WriteLine($"Area: {area} cm.");
            Console.Read();
        }
    }
}
