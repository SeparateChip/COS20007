                                                                                                                                                                                                                                                                                using System;
using System.IO;
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

        public override void SaveTo(StreamWriter writer)
        {
            writer.WriteLine("Line");
            base.SaveTo(writer);
            writer.WriteLine(_line.StartPoint.X);
            writer.WriteLine(_line.StartPoint.Y);
            writer.WriteLine(_line.EndPoint.X);
            writer.WriteLine(_line.EndPoint.Y);
        }

        public override void LoadFrom(StreamReader reader)
        {
            base.LoadFrom(reader);
            _line.StartPoint.X = reader.ReadInteger();
            _line.StartPoint.Y = reader.ReadInteger();
            _line.EndPoint.X = reader.ReadInteger();
            _line.EndPoint.Y = reader.ReadInteger();
        }



    }
}

