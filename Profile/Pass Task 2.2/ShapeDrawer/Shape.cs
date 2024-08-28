using System;
using SplashKitSDK;

namespace ShapeDrawer
{

    class Shape
    {

        private Color _color;
        private float _x, _y;
        private int _width, _height;
        public Shape()
        {
            _color = Color.Purple;
            _x = 0;
            _y = 0;
            _width = 100;
            _height = 100;
        }

        public Color Color
        {
            get { return _color; }

            set { _color = value; }


        }
       
        public float X
        {
            get { return _x; }

            set { _x = value; }
        }

        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public int width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }   
        }
        public void Draw ()
        {
            SplashKit.FillRectangle(_color,_x,_y,_width, _height);
        }


        public bool IsAt(Point2D pt)
        {
            if (pt.X >= _x && pt.X <= (_x + _width) && pt.Y >= _y && pt.Y <= (_y + _height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}