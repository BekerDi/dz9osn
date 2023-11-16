using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzfiguri
{
    public abstract class Figure
    {
        protected string color;
        protected bool isVisible;

        public Figure(string initialColor, bool initialVisibility)
        {
            color = initialColor;
            isVisible = initialVisibility;
        }

        public abstract void MoveHorizontal(int distance);
        public abstract void MoveVertical(int distance);
        public abstract void SetColor(string newColor);
        public abstract void SetVisibility(bool newVisibility);

        public string GetColor()
        {
            return color;
        }

        public bool IsVisible()
        {
            return isVisible;
        }

        public virtual void Display()
        {
            Console.WriteLine("Цвет: " + color);
            Console.WriteLine("Видимость: " + isVisible);
        }
    }
}

