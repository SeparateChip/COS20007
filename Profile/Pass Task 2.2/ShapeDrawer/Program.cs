using System;
using SplashKitSDK;


namespace ShapeDrawer
{
    public class Program
    {
        public static void Main()
        {
            new Window("Shape Drawer", 800, 600);
            Shape myShape = new Shape();

            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();

                

                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Point2D mousePostion = SplashKit.MousePosition();
                    myShape.X = SplashKit.MouseX();
                    myShape.Y = SplashKit.MouseY();
                    Console.WriteLine("leftClick");

                }

                if (myShape.IsAt(SplashKit.MousePosition()) && SplashKit.KeyTyped(KeyCode.SpaceKey))
                {
                    myShape.Color = SplashKit.RandomRGBColor(255);
                    Console.WriteLine("SpaceBar");
                }

                myShape.Draw();

                SplashKit.RefreshScreen();
            }
            while (!SplashKit.WindowCloseRequested("Shape Drawer"));

        }
    }



}