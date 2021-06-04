using System;
using System.Drawing;

namespace Snakes
{
    class Apple
    {
        private string type;
        private int fat;
        private int posX;
        private int posY;
        private string face;
        Random rand = new Random();
        public Apple()
        {
        }
        public string Face { set { face = value; } get { return face; } }
        public int Fat { set { fat = value; } get { return fat; } }
        public string Type { set { type = value; } get { return type; } }
        public Point Rearesh()
        {
            posX = rand.Next(0, 20) * 25 + 5;
            posY = rand.Next(0, 20) * 25 + 5;
            fat = 1;
            if (rand.Next(0, 5) == 4)
            {
                type = "s";
                face = "apple2.ico";
            }
            else
            {
                type = "";
                face = "apple1.ico";
            }
            return new Point(posX, posY);
        }

    }
}
