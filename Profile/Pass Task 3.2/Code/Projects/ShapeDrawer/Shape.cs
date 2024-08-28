﻿using System;
using SplashKitSDK;
using System.Collections.Generic;

namespace ShapeDrawer
{

    public class Shape
    {

        private Color _color;
        private bool _selected;
        private float _x, _y;
        private int _width, _height;
        public Shape()
        {
            _color = Color.Purple; //yes love me some purple :)
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

        public int height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }


        public void Draw ()

        {   if (_selected)
            {
                DrawOutline();
            }
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

        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }

        public void DrawOutline()
        {
            SplashKit.FillRectangle(Color.Black, _x - 2, _y - 2, _width + 4, _height + 4);
        }


    }

}