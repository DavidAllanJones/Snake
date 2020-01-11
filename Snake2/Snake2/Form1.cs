using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake2
{
    public partial class Form1 : Form
    {
        private bool czy_gra_aktywna; // sprawdzenie czy gra się już rozpoczeła 
        private Snake waz; // utworzenie weza 
        private Owoc owoc; 

        public Form1()
        {
            InitializeComponent();
            czy_gra_aktywna = false; // przypisanie w konstruktorze 
            timer1.Enabled = true; // wywołanie zdarzenia Tick dla timera 
            pauzaToolStripMenuItem.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                pole_gry.CreateGraphics().Clear(Color.Black); // czyścimy pole gry kiedy gra jest aktywna
                waz.move(); // wywolanie metody move 
                waz.rysuj(pole_gry.CreateGraphics(), new SolidBrush(Color.Aqua));  // waz.rysuj + parametry metody 
                owoc.rysuj_owoc(pole_gry.CreateGraphics(), new SolidBrush(Color.Red)); // uruchamiamy rysowanie owocu 

                if (owoc.czy_nowy_owoc(waz.x[0], waz.y[0]))
                {
                    waz.dodaj();
                }
                if (waz.czy_waz_zyje() == false)
                {
                    czy_gra_aktywna = false;
                }
            }
            else
            {
                FontFamily fontFamily1 = new FontFamily("Arial"); // tworzenie obiektu typu FontFamily
                Font f = new Font(fontFamily1, 15);
                Brush b = new SolidBrush(Color.Aqua); // kolor jakim chcemy pisać 
                pole_gry.CreateGraphics().DrawString("Naciśnij Start", f, b, 50, 50); // 1.tekst, który chcemy utworzyć 2.obiekt typu font 3.obiekt typu brush, 4.współrzędne x i y 
                
            }
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            czy_gra_aktywna = true;
            waz = new Snake(pole_gry.Width, pole_gry.Height);
            owoc = new Owoc(waz.segment);
            pauzaToolStripMenuItem.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) waz.ruch = "gora";
            if (e.KeyCode == Keys.Down) waz.ruch = "dol";
            if (e.KeyCode == Keys.Right) waz.ruch = "prawo";
            if (e.KeyCode == Keys.Left) waz.ruch = "lewo";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pauzaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (czy_gra_aktywna)
            {
                czy_gra_aktywna = false;
                pauzaToolStripMenuItem.Text = "Wznów";
                pole_gry.CreateGraphics().Clear(Color.Black);
            }
            else
            {
                czy_gra_aktywna = true;
                pauzaToolStripMenuItem.Text = "Pauza";
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e) // resetowanie 
        {
            if (czy_gra_aktywna)
            {
                waz = new Snake(pole_gry.Width, pole_gry.Height);
                owoc = new Owoc(waz.segment);
            }
        }

        private void szybciejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (timer1.Interval > 10) { timer1.Interval -= 10; }
        }

        private void wolniejToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Interval += 10;
        }
    }
}
