using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    class Snake
    {
        private bool heath;
        private int fat;
        private int speed;
        private PictureBox[] images = new PictureBox[400];
        public Snake()
        {

            heath = true;
            fat = 0;
            speed = 500;
            images[0] = new PictureBox();
            images[0].Location = new Point(5, 5);
            images[0].Size = new Size(25, 25);
            images[0].Image = Image.FromFile("HeadR.png");
            images[0].SizeMode = PictureBoxSizeMode.Zoom;         
        }
        public int Speed { set { speed = value ; } get { return speed; } }
        public int Fat { set { fat = value; } get { return fat; } }
        public PictureBox[] IImages { set { images = value; } get { return images; } }
        public void go(string dir)
        {
            if (fat > 0)
            {
                for (int i = fat; i > 0; i--)
                {
                    images[i].Location = new Point(images[i - 1].Location.X, images[i - 1].Location.Y);
                }
            }
            switch (dir)
            {
                case "Right":
                    images[0].Image = Image.FromFile("HeadR.png");
                    images[0].Location = new Point(images[0].Location.X + 25, images[0].Location.Y);
                break;
                case "Left":
                    images[0].Image = Image.FromFile("HeadL.png");
                    images[0].Location = new Point(images[0].Location.X - 25, images[0].Location.Y);
                break;
                case "Up":
                    images[0].Image = Image.FromFile("HeadU.png");
                    images[0].Location = new Point(images[0].Location.X, images[0].Location.Y - 25);
                break;
                case "Down":
                    images[0].Image = Image.FromFile("HeadD.png");
                    images[0].Location = new Point(images[0].Location.X, images[0].Location.Y + 25);
                break;
            }

        }
        public void eat(int apple, string type)
        {
            fat += apple;
            if (type == "s")
                speed -= 100;
            images[fat] = new PictureBox();
            images[fat].Location = new Point(images[0].Location.X, images[0].Location.Y);
            images[fat].Size = new Size(25, 25);
            images[fat].Image = Image.FromFile("Body.png");
            images[fat].SizeMode = PictureBoxSizeMode.Zoom;


        }
        public bool deathorlive()
        {
            for (int i = 1; i <= fat; i++)
            {
                if (images[0].Location == images[i].Location)
                {
                    heath = false;
                    return heath;
                }
            }
            if (0 > images[0].Location.X || images[0].Location.X > 500 || images[0].Location.Y > 500 || 0 > images[0].Location.Y)
                heath = false;
            return heath;
        }
    }
}
