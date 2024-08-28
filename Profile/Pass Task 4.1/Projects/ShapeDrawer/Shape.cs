﻿using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace ShapeDrawer
{
    public abstract class Shape
    {
        protected Color _color;
        private bool _selected;
        private float _x, _y;



        public Shape(): this(Color.Purple)
        {
            
            _x = 0;
            _y = 0;
        }

        public Shape(Color clr)
        {
            _color = clr;
        }

        public Color COLOR
        {
            get 
            { 
                return _color; 
            }
            set 
            { 
                _color = value; 
            }
        }

        public float X
        {
            get 
            { 
                return _x; 
            }
            set 
            { 
                _x = value; 
            }
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



        public abstract void Draw();

        public abstract bool IsAt(Point2D pt);

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

        public abstract void DrawOutline();
    }
}
