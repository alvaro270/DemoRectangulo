using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoRectangulo
{
    class rectangulo
    {
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }
        public Punto Punto4 { get; set; }
        //operacion matricial entre las coordenadas
        double Multi(Punto punt)
        {
            double mul;
            mul = punt.x * punt.y;
            return mul;
        }
        public double Area(Punto Punto1, Punto Punto2, Punto Punto3, Punto Punto4)
        {
            double a1,a2, a3, a4,AreaR;
            a1 = Multi(Punto1);
            a2 = Multi(Punto2);
            a3 = Multi(Punto3);
            a4 = Multi(Punto4);
            //separe la operacion para que sea mas facil que se ejecuten
            AreaR = Math.Abs((a1+a2+a3+a4) - (a1-a2-a3-a4));
            return (AreaR / 2);
        }
        //para hallar el perimetro del rectangulo, primero se
        //halla la distancia entre 2 puntos de cada segmento
        int Distanc(Punto punt1, Punto punt2)
        {
            int dis;
            dis = 2*(punt1.x - punt2.x) + 2*(punt1.y - punt2.y);
            return dis;
        }
        public double Perimetro(Punto Punto1, Punto Punto2, Punto Punto3, Punto Punto4)
        {
            double d1,d2,d3,d4,Perimetro;
            d1 = Distanc(Punto1, Punto2);
            d2 = Distanc(Punto2, Punto3);
            d3 = Distanc(Punto3, Punto4);
            d4 = Distanc(Punto4, Punto1);
            Perimetro = d1+d2+d3+d4;
            return Perimetro;
        }
    }
}
