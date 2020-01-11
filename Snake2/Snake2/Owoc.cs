using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake2
{
    class Owoc
    {
        public int x;
        public int y;
        public int segment;

        public void nowy_owoc()
        {
            Random r = new Random();  // nadajemy pseudolosowe wartosci x i y 
            x = r.Next(0, 20) * segment;
            y = r.Next(0, 20) * segment;
        }

        public Owoc(int segment)
        {
            this.segment = segment; // wielkosc segmentu przypisujemy do pola segment
            nowy_owoc(); // wywołujemy nowy owoc 
        }

        public bool czy_nowy_owoc(int glowa_x, int glowa_y) // sprawdzamy czy generować nowy owoc 
        {
            if (x == glowa_x && y == glowa_y)
            {
                nowy_owoc();
                return true;
            }
            return false;
        }

        public void rysuj_owoc(Graphics g, Brush b) // rysowanie owocu 
        {
            g.FillRectangle(b, x, y, segment, segment);
        }
    }
}
