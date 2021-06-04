using System;
using System.Drawing;
using System.Windows.Forms;

namespace Snakes
{
    public partial class Form1 : Form
    {
        string direction;
        Snake snake;
        Apple apple;

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
            snake.IImages[0].Show();
            timer1.Interval = snake.Speed;
            timer1.Start();
            snake.IImages[0].BringToFront();
            food.Image = Image.FromFile("apple1.ico");
            map.Image = Image.FromFile("Map.bmp");
        }
        private new void KeyPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    if (direction != "Left")
                        direction = "Right";
                    break;
                case "Left":
                    if (direction != "Right")
                        direction = "Left";
                    break;
                case "Up":
                    if (direction != "Down")
                        direction = "Up";
                    break;
                case "Down":
                    if (direction != "Up")
                        direction = "Down";
                    break;
            }
        }
        private void eat()
        {
            if (snake.IImages[0].Location == food.Location)
            {
                food.Location = apple.Rearesh();
                food.Image = Image.FromFile(apple.Face);
                snake.eat(apple.Fat, apple.Type);
                this.Controls.Add(snake.IImages[snake.Fat]);
                snake.IImages[snake.Fat].BringToFront();
                timer1.Interval = snake.Speed;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            eat();
            snake.go(direction);
            if (snake.deathorlive() == false)
                endgame();
            label2.Text = snake.Fat.ToString();
            GC.Collect();
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
