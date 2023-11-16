using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    internal class Point: Figure
    {
        private int x;
        private int y;

        public Point(string initialColor, bool initialVisibility, int initialX, int initialY) : base(initialColor, initialVisibility)
        {
            x = initialX;
            y = initialY;
        }

        public override void MoveHorizontal(int distance)
        {
            x += distance;
        }

        public override void MoveVertical(int distance)
        {
            y += distance;
        }

        public override void SetColor(string newColor)
        {
            color = newColor;
        }

        public override void SetVisibility(bool newVisibility)
        {
            isVisible = newVisibility;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
    }
}

