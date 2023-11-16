using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    internal class Circle  :Point
    {

        private double radius;

        public Circle(string initialColor, bool initialVisibility, int initialX, int initialY, double initialRadius) : base(initialColor, initialVisibility, initialX, initialY)
        {
            radius = initialRadius;
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

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public override void Display()
        {
            base.Display();

        }
    }
}
