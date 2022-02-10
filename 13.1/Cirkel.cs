using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _13._1
{
    class Cirkel
    {
        private int x = 0;
        private int y = 0;
        private int diameter = 40;

        public Cirkel(int x, int y, int diameter)
        {
            X = x;
            Y = y;
            diameter = diameter;
        }
        #region Egenskaper
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Diameter
        {
            get { return diameter; }
            set { if (value < 0) diameter = -value; else diameter = value; }
        }
        #endregion

        public void Rita(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Red), X, Y, Diameter, Diameter);
        }

        public bool ÄrTräffad(int musX, int MusY)
        {
            bool träffad = false;
            int dx = musX - (X+Diameter/2);
            int dy = MusY - (Y+Diameter/2);
            int ds2 = dx*dx + dy*dy;
            if (ds2 < (Diameter/2) * (diameter/2))
            {
                träffad = true;

            }
            return träffad;
        }
    }


}
