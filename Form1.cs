using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);
        [Flags]
        public enum MouseEventFlags : uint
        {
            LEFTDOWN = 0x00000002,
            LEFTUP = 0x00000004,
            MIDDLEDOWN = 0x00000020,
            MIDDLEUP = 0x00000040,
            MOVE = 0x00000001,
            ABSOLUTE = 0x00008000,
            RIGHTDOWN = 0x00000008,
            RIGHTUP = 0x00000010
        }

        Enemy Rect1;
        Enemy Rect2;
        Enemy Rect3;
        Enemy Rect4;
        Enemy Rect5;
        Enemy Rect6;
        Enemy Rect7;
        Enemy Rect8;
        Enemy Rect9;
        Enemy Rect10;
        private int SquareW;
        private int Speed;
        private int SquareSpeed;
        public int Score;
        private int HeightT;
        private int WidthT;
        public int ShowSpeed;
        int random_0_11;
        int ScoreX;
        Point mouse_location;
        public Form1()
        {
            InitializeComponent();
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer | ControlStyles.UserPaint, true);
            ShowSpeed = 1000;
            SquareW = 100;
            Speed = 5;
            SquareSpeed = 2;
            ScoreX = 500;
            Score = 0;
            HeightT = 700;
            WidthT = 1200;
            this.Size = new Size(WidthT, HeightT);

            Random rnd = new Random();


            Rect1 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, false, true, true);
            Rect2 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect3 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect4 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect5 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect6 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect7 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect8 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect9 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);
            Rect10 = new Enemy(rnd.Next(0, (WidthT - 10) - SquareW), rnd.Next(0, (HeightT - 10) - SquareW), SquareW, true, true, true);

            Rndall();

            timer1.Interval = Speed;
            timer2.Interval = Speed - 1;
            timer3.Interval = ShowSpeed;
            timer4.Interval = 1;
            timer1.Tick += new EventHandler(update);
            timer2.Tick += new EventHandler(BounceUpdate);
            timer3.Tick += new EventHandler(ShowRnd);
            timer4.Tick += new EventHandler(UpdateAll);
            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();
            this.MouseDown += Check;
        }

        private void UpdateAll(object sender, EventArgs e)
        {
            score.Text = Score.ToString();
            if(Score > 1000)
            {
                SquareSpeed = 4;
            }
            if(Score > 3000)
            {
                ShowSpeed = 700;
            }
            if(Score > 5000)
            {
                SquareSpeed = 7;
            }
            if(Score > 7000)
            {
                SquareW = 70;
            }
            SetSquare(Rect1);
            SetSquare(Rect2);
            SetSquare(Rect3);
            SetSquare(Rect4);
            SetSquare(Rect5);
            SetSquare(Rect6);
            SetSquare(Rect7);
            SetSquare(Rect8);
            SetSquare(Rect9);
            SetSquare(Rect10);
        }
        private void SetSquare(Enemy c)
        {
            c.rec.Width = SquareW;
            c.rec.Height = SquareW;
        }
        private void ShowRnd(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if(Rect1.isHide == false && Rect2.isHide == false && Rect3.isHide == false && Rect4.isHide == false && Rect5.isHide == false && Rect6.isHide == false && Rect7.isHide == false && Rect8.isHide == false && Rect9.isHide == false && Rect10.isHide == false)
            {

            }
            else
            {
                while (true)
                {
                    random_0_11 = rnd.Next(0, 11);
                    if (random_0_11 == 1)
                    {
                        if (Rect1.isHide)
                        {
                            Rect1.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 2)
                    {
                        if (Rect2.isHide)
                        {
                            Rect2.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 3)
                    {
                        if (Rect3.isHide)
                        {
                            Rect3.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 4)
                    {
                        if (Rect4.isHide)
                        {
                            Rect4.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 5)
                    {
                        if (Rect5.isHide)
                        {
                            Rect5.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 6)
                    {
                        if (Rect6.isHide)
                        {
                            Rect6.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 7)
                    {
                        if (Rect7.isHide)
                        {
                            Rect7.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 8)
                    {
                        if (Rect8.isHide)
                        {
                            Rect8.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 9)
                    {
                        if (Rect9.isHide)
                        {
                            Rect9.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (random_0_11 == 10)
                    {
                        if (Rect10.isHide)
                        {
                            Rect10.isHide = false;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                }
            }
            
        }
        private void Hide(Enemy c)
        {
            if (HitBoxCheck(c))
            {
                c.isHide = true;
            }
        }
        private void Check(object sender, MouseEventArgs e)
        {
            mouse_location = new Point(e.X, e.Y);
            if(e.Button == MouseButtons.Left)
            {
                Hide(Rect1);
                Hide(Rect2);
                Hide(Rect3);
                Hide(Rect4);
                Hide(Rect5);
                Hide(Rect6);
                Hide(Rect7);
                Hide(Rect8);
                Hide(Rect9);
                Hide(Rect10);
            }
        }
        private bool HitBoxCheck(Enemy c)
        {
            Point SquareHitBox;
            bool gotIt = false;
            if (c.isHide)
            {
                return false;
            }
            else
            {
                for (int i = c.rec.X; i <= c.rec.X + SquareW; i++)
                {
                    for (int j = c.rec.Y; j <= c.rec.Y + SquareW; j++)
                    {
                        SquareHitBox = new Point(i, j);
                        if (SquareHitBox == mouse_location)
                        {
                            gotIt = true;
                            break;
                        }
                    }
                    if (gotIt)
                    {
                        break;
                    }
                }
                if (gotIt)
                {
                    Score += ScoreX;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        private void BounceUpdate(object sender, EventArgs e)
        {
            Bounce(Rect1);
            Bounce(Rect2);
            Bounce(Rect3);
            Bounce(Rect4);
            Bounce(Rect5);
            Bounce(Rect6);
            Bounce(Rect7);
            Bounce(Rect8);
            Bounce(Rect9);
            Bounce(Rect10);
            score.Text = Score.ToString();
        }

        private void Rndall()
        {
            Rnd(Rect1);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect2);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect3);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect4);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect5);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect6);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect7);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect8);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect9);
            for (int i = 0; i < 10000000; i++)
            {

            }
            Rnd(Rect10);
            for (int i = 0; i < 10000000; i++)
            {

            }
        }
        private void Rnd(Enemy c)
        {
            Random rnd = new Random();
            if (rnd.Next(-1,2) == 1)
            {
                c.RightLeft = true;
            }
            else
            {
                c.RightLeft = false;
            }
            if(rnd.Next(-1,2) == 1)
            {
                c.UpDown = true;
            }
            else
            {
                c.UpDown = false;
            }
        }
        private void update(object sender, EventArgs e)
        {
            MoveT(Rect1);
            MoveT(Rect2);
            MoveT(Rect3);
            MoveT(Rect4);
            MoveT(Rect5);
            MoveT(Rect6);
            MoveT(Rect7);
            MoveT(Rect8);
            MoveT(Rect9);
            MoveT(Rect10);
            Invalidate();
            
        }

        private void MoveT(Enemy c)
        {
            if (c.isHide == false)
            {
                if (c.RightLeft)
                {
                    c.rec.X += SquareSpeed;
                }
                else
                {
                    c.rec.X -= SquareSpeed;
                }
                if (c.UpDown)
                {
                    c.rec.Y -= SquareSpeed;
                }
                else
                {
                    c.rec.Y += SquareSpeed;
                }
            }
            Invalidate();
        }
        private void Bounce(Enemy c)
        {
            if (c.rec.X < 0 || c.rec.X > (WidthT - 10) - SquareW)
            {
                c.RightLeft = !c.RightLeft;
            }
            if (c.rec.Y < 0 || c.rec.Y > (HeightT - 30) - SquareW)
            {
                c.UpDown = !c.UpDown;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void Solid(Color color,Enemy rec,PaintEventArgs e)
        {
            e.Graphics.FillRectangle(new SolidBrush(color), rec.rec);
        }
        private void OnPaint(object sender, PaintEventArgs e)
        {
            if (Rect1.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Red, Rect1.rec);
                Solid(Color.Red, Rect1, e);
            }
            if (Rect2.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Yellow, Rect2.rec);
                Solid(Color.Yellow, Rect2, e);
            }
            if (Rect3.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Green, Rect3.rec);
                Solid(Color.Green, Rect3, e);
            }
            if (Rect4.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Aqua, Rect4.rec);
                Solid(Color.Aqua, Rect4, e);
            }
            if (Rect5.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Silver, Rect5.rec);
                Solid(Color.Silver, Rect5, e);
            }
            if (Rect6.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Gray, Rect6.rec);
                Solid(Color.Gray, Rect6, e);
            }
            if (Rect7.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.DarkGray, Rect7.rec);
                Solid(Color.DarkGray, Rect7, e);
            }
            if (Rect8.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Brown, Rect8.rec);
                Solid(Color.Brown, Rect8, e);
            }
            if (Rect9.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.Coral, Rect9.rec);
                Solid(Color.Coral, Rect9, e);
            }
            if (Rect10.isHide == false)
            {
                e.Graphics.DrawRectangle(Pens.DarkGreen, Rect10.rec);
                Solid(Color.DarkGreen, Rect10, e);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
