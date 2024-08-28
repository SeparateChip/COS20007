using System;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle,
            Circle,
            Line
        }

        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Rectangle;
            Point2D lineStart = new Point2D() { X = 0, Y = 0 };
            Point2D lineEnd;

            new Window("Shape Drawer", 800, 600);
            Drawing drawObject = new Drawing();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();


                if(SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                    Console.WriteLine("RKEY");
                }
                else if(SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                    lineStart.X = SplashKit.MouseX();
                    lineStart.Y = SplashKit.MouseY();
                    Console.WriteLine("LKEY");
                }
                else if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                    Console.WriteLine("CKEY");
                }


                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape = null;

                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        MyRectangle newRectangle = new MyRectangle();
                        newRectangle.X = SplashKit.MouseX();
                        newRectangle.Y = SplashKit.MouseY();
                        newShape = newRectangle;

                    }
                    else if (kindToAdd == ShapeKind.Circle)
                    {
                        MyCircle newCircle = new MyCircle();
                        newCircle.X = SplashKit.MouseX();
                        newCircle.Y = SplashKit.MouseY();
                        newShape = newCircle;
                    }

                    else if(kindToAdd == ShapeKind.Line)
                    {
                        lineEnd.X = SplashKit.MouseX();
                        lineEnd.Y = SplashKit.MouseY();
                        Line tempLine;
                        tempLine.StartPoint = lineStart;
                        tempLine.EndPoint = lineEnd;
                        MyLine newLine = new MyLine(tempLine);
                        newShape = newLine;
                    }

                    drawObject.AddShape(newShape);
                    Console.WriteLine("leftClick");
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    Console.WriteLine("SpaceKey");
                    drawObject.Background = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
                    Console.WriteLine("RightClick");
                    Point2D mousePos = SplashKit.MousePosition();
                    drawObject.SelectShapesAt(mousePos);
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey) || SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                    {
                        Console.WriteLine("Backspace");
                    }
                    if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                    {
                        Console.WriteLine("Delete");
                    }
                    drawObject.RemoveShape();
                }

                drawObject.Draw();
                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));
        }
    }
}
