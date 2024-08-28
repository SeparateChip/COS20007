using System;
using SplashKitSDK;
using System.Collections.Generic;


namespace ShapeDrawer
{
    public class MyLine : Shape
    {
        Line _line;
        DrawingOptions DrawingOptions = new DrawingOptions() { LineWidth = 5 };
        public MyLine(Line line)
        {
          _line = line;
        }

        public MyLine()
        {

        }

        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SplashKit.DrawLine(_color, _line);
        }


        public override void DrawOutline()
        {
            SplashKit.FillCircle(Color.Black, _line.EndPoint.X, _line.EndPoint.Y, 4);
            SplashKit.FillCircle(Color.Black, _line.StartPoint.X, _line.StartPoint.Y, 4);
        }

        public override bool IsAt(Point2D p)
        {
            return SplashKit.PointOnLine(p, _line);
        }
    }
}

