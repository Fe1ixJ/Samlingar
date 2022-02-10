using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13._1
{
    public partial class Form1 : Form
    {
        private List<Cirkel> cirklar = new List<Cirkel>();
        private bool speletÄrSlut = false;
        public Form1()
        {
            InitializeComponent();
            for (int rad = 0; rad <4; rad++)
            {
                for (int kolumn = 0; kolumn < 6; kolumn++)
                {
                    int x = 10 + 50 * kolumn;
                    int y = 10 + 50 * rad;
                    int diameter = 20;
                    Cirkel cirkel = new Cirkel(x, y, diameter);
                    cirklar.Add(cirkel);
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int i = 0; i < cirklar.Count; i++)
            {
                Cirkel cirkel = cirklar.ElementAt(i);
                cirkel.Rita(g);
            }
            if (speletÄrSlut)
            {
                string text = "grattis";
                Font font = new Font("Arial", 30);
                SolidBrush brush = new SolidBrush(Color.Blue);
                int x = 25;
                int y = 30;
                g.DrawString(text, font, brush, x, y);
            }
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            bool träff = false;
            for (int i = 0; i<cirklar.Count && !träff; i++)
            {
                Cirkel cirkel = cirklar.ElementAt(i);
                if (cirkel.ÄrTräffad(e.X, e.Y))
                {
                    cirklar.RemoveAt(i);
                    träff = true;
                }
            }
            if (cirklar.Count == 0)
            {
                speletÄrSlut = true;
            }
            Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
