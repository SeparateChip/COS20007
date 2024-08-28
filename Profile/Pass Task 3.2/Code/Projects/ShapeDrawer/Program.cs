using System;
using SplashKitSDK;

namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Drawing drawObject = new Drawing();
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape = new Shape();
                    newShape.X = SplashKit.MouseX();
                    newShape.Y = SplashKit.MouseY();
                    drawObject.AddShape(newShape);
                    Console.WriteLine("LeftClick");
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
