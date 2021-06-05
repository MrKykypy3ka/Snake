using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Snakes
{
    public partial class Form1 : Form
    {
        private string direction;
        private Snake snake;
        private Apple apple;
        private int tic;
        SoundPlayer sp = new SoundPlayer("www.wav");

        public Form1()
        {
            InitializeComponent();
            DialogResult result = MessageBox.Show("Начать игру", "Привет!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                newgame();
            if (result == DialogResult.No)
                Environment.Exit(0);
        }
        private void newgame()
        {
            snake = new Snake();
            apple = new Apple();
            direction = "Right";
            this.KeyUp += new KeyEventHandler(KeyPress);
            this.Controls.Add(snake.IImages[0]);
            this.Controls.Add(apple.AApple);
            timer1.Interval = snake.Speed;
            timer1.Start();
            snake.IImages[0].BringToFront();
            snake.IImages[0].Parent = map;
            apple.AApple.Parent = map;
            snake.IImages[0].BackColor = Color.Transparent;
            apple.AApple.BackColor = Color.Transparent;
            map.Image = Image.FromFile("Map.png");
            Board.Image = Image.FromFile("Board.png");
            Board.SizeMode = PictureBoxSizeMode.Zoom;
            sp.Play();
        }
        private new void KeyPress(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Right" || e.KeyCode.ToString() == "Left" || e.KeyCode.ToString() == "Up" || e.KeyCode.ToString() == "Down"))
                direction = e.KeyCode.ToString();
        }
        private void eat()
        {
            snake.eat(apple.Fat, apple.Type);
            apple.Rearesh(snake.IImages, snake.Fat);
            this.Controls.Add(snake.IImages[snake.Fat]);
            snake.IImages[snake.Fat].BringToFront();
            snake.IImages[snake.Fat].Parent = map;
            snake.IImages[snake.Fat].BackColor = Color.Transparent;
            snake.IImages[0].BringToFront();
            timer1.Interval = snake.Speed;
            label2.Text = snake.Fat.ToString();
            label4.Text = (((snake.Speed - 500) * (-1))/50).ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (snake.IImages[0].Location == apple.AApple.Location)
                eat();
            snake.go(direction);
            if (snake.deathorlive() == false)
                endgame();
            tic += timer1.Interval;
            if (tic > 181000)
            {
                tic = 0;
                sp.Play();
            }
        }
        private void endgame()
        {
            timer1.Stop();
            DialogResult result = MessageBox.Show("Счёт:" + snake.Fat.ToString(),"Конец игры",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Application.Restart();
            if (result == DialogResult.No)
                this.Close();
        }
    }
}
