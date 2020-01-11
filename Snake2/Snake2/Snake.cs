using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing; // potrzebne do parametrów Graphics i Brush 

namespace Snake2
{
    class Snake
    {
        public int segmenty; // składowe węża 
        public int segment; // wartość jednego segmentu węża
        
        public int[] x = new int[900]; // współrzędne do określenia lokalizacji segmentów węża 
        public int[] y = new int[900];
        public string ruch; // (prawo, lewo , góra dół)

        public Snake(int szerokosc, int wysokosc) // podajemy szerokosc i wysokosc pola, na którym rozgrywana bedzie gra  
        {
            segment = szerokosc / 20; // szerokosc do obl wielkosci jednego segmentu 
            segmenty = 3; // początkowa liczba segmentów 
            ruch = "prawo";   // na początku gry wąż bedzie sie poruszać w prawo

            int xg = 9 * segment;   // 20 segmentow szerokosc pola, dziesiąty segment głowa (x = suma 9 szerokosci segmentów)
            int yg = 9 * segment; 

            for (int i=0; i < segmenty; i++) // przypisywanie odpowiednich wartości x i y 
            {
                x[i] = xg - (i * segment);
                y[i] = yg;
            }
        }

        public void move() // wartosci osi y rosną do dołu okna gry, na osi x rosna w prawą stronę
        {
            for (int i = segmenty; i > 0; i--)
            {
                x[i] = x[(i - 1)];
                y[i] = y[(i - 1)];
            }
            if(ruch == "lewo")
            {
                x[0] = x[0] - segment;
            }
            if(ruch == "prawo")
            {
                x[0] = x[0] + segment;
            }
            if(ruch == "gora")
            {
                y[0] = y[0] - segment;
            }
            if (ruch == "dol")
            {
                y[0] = y[0] + segment;
            }
            if (x[0] < 0) { x[0] = segment * 19; } // jezeli x jest mniejsza niz najmniejsza przenosimy do takiego x ktory jest najwiekszy 
            if (x[0] > segment * 20) { x[0] = 0; }
            if (y[0] < 0) { y[0] = segment * 19; }
            if (y[0] > segment * 20) { y[0] = 0; }
        }

        public void rysuj(Graphics g, Brush b) // rysowanie segmentow , obiekt graficzny + pedzel 
        {
            for(int i = 0; i < segmenty; i++)
            {
                g.FillRectangle(b, x[i], y[i], segment, segment); // wypelniamy kolorem prostokąt (pedzel, wspolrzedne x lewej krawedzi, y górnej krawedzi, szerokosc, wysokosc
            }

        }
        public void dodaj()
        {
            x[segmenty] = x[segmenty - 1];
            y[segmenty] = y[segmenty - 1];
            segmenty = segmenty + 1;
        }
        public bool czy_waz_zyje() // jesli ktorys z segmentow pokrywa sie z lokalizacja glowy metoda zwraca false
        {
            for (int i = 1; i < segmenty; i++)
            {
                if (x[0] == x[i] && y[0] == y[i])
                {
                    return false;
                }
            }
            return true;
        }
    }
    
}
