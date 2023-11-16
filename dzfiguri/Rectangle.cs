using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    internal class Rectangle: Point
    {

        private double length;
        private double width;
        public Rectangle(string initialColor, bool initialVisibility, int initialX, int initialY, double initialLenght, double initialWidth) : base(initialColor, initialVisibility, initialX, initialY)
        {
            length = initialLenght;
            width = initialWidth;
        }
        public override void MoveHorizontal(int distance)
        {
            base.MoveHorizontal(distance);
        }
        public override void MoveVertical(int distance)
        {
            base.MoveVertical(distance);
        }
        public override void SetColor(string newColor)
        {
            base.SetColor(newColor);
        }
        public override void SetVisibility(bool newVisibility)
        {
            base.SetVisibility(newVisibility);
        }
        public double CalculateAreaRec()
        {
            return length * width;
        }
        public override void Display()
        {
            base.Display();

        }

    }

}

