using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{
    public class MyCircle : Shape
    {
        private int _radius;

        public MyCircle() : this(Color.Green, 50)
        { 
        
        }

        public MyCircle(Color clr, int radius)
        {
            _radius = radius;
            _color = clr;
        }

        public override bool IsAt(Point2D pt)
        {
            double xDiff = (pt.X - X) * (pt.X - X);
            double yDiff = (pt.Y - Y) * (pt.Y - Y);


            if (Math.Sqrt(xDiff + yDiff) < _radius)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.FillCircle(_color, X, Y, _radius);
        }


        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, X, Y, _radius + 2);
        }
    }
}
