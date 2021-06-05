﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    class Apple
    {
        private string type;
        private int fat;
        Random rand = new Random();
        private PictureBox apple = new PictureBox();
        public Apple()
        {
            apple = new PictureBox();
            apple.Location = new Point(205, 205);
            apple.Size = new Size(25, 25);
            apple.Image = Image.FromFile("apple1.ico");
            apple.SizeMode = PictureBoxSizeMode.Zoom;
            fat = 1;
            type = "";
        }
        public int Fat { set { fat = value; } get { return fat; } }
        public string Type { set { type = value; } get { return type; } }
        public PictureBox AApple { set { apple = value; } get { return apple; } }
        public void Rearesh()
        {
            apple.Location = new Point(rand.Next(0, 20) * 25 + 5, rand.Next(0, 20) * 25 + 5);
            fat = 1;
            if (rand.Next(0, 5) == 4)
            {
                type = "s";
                apple.Image = Image.FromFile("apple2.png");
            }
            else
            {
                type = "";
                apple.Image = Image.FromFile("apple1.ico");
            }
        }

    }
}
