using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Punto
    {
        int x;
        int y;

        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    public class Rectangulo
    {
        float area;
        float perimetro;
        Punto vertice1;
        Punto vertice2;
        Punto vertice3;
        Punto vertice4;

        public float Area()
        {
            if (this.area == 0)
            {
                int laBase = Math.Abs(vertice3.GetX() - vertice1.GetX());
                int laAltura = Math.Abs(vertice1.GetY() - vertice3.GetY());

                return laBase * laAltura;
            }
            else
            {
                return this.area;
            }
        }
        public float Perimetro()
        {
            if (this.perimetro == 0)
            {
                int laBase = Math.Abs(vertice3.GetX() - vertice1.GetX());
                int laAltura = Math.Abs(vertice1.GetY() - vertice3.GetY());

                return (laBase + laAltura) * 2;
            }
            else
            {
                return this.perimetro;
            }
        }
        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = new Punto(vertice3.GetX(), vertice1.GetY());
            this.vertice4 = new Punto(vertice1.GetX(), vertice3.GetY());
            /*
            int laBase = Math.Abs(vertice3.GetX() - vertice1.GetX());
            int laAltura = Math.Abs(vertice1.GetY() - vertice3.GetY());
            this.perimetro = (laBase + laAltura) * 2;
            this.area = laBase * laAltura;
            */
        }
    }
}
