using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Enemy
    {
        public int x;
        public int y;
        private int a;
        public bool isHide;
        public bool RightLeft;
        public bool UpDown;
        public Rectangle rec;
        public Enemy(int x, int y, int a, bool isHide, bool RightLeft, bool UpDown)
        {
            this.x = x;
            this.y = y;
            this.a = a;
            this.isHide = isHide;
            this.RightLeft = RightLeft;
            this.UpDown = UpDown;
            rec.X = x;
            rec.Y = y;
            rec.Height = a;
            rec.Width = a;
        }
    }
}
