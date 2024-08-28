using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace ShapeDrawer
{

    class Drawing
    {
        
        private readonly List<Shape> _shapes;
        private Color _background;

        public Drawing(Color background)
        {
            _shapes = new List<Shape>();
            _background = background;
        }

        public Drawing() : this(Color.White)
        {

        }





        public int ShapeCount
        {
            get 
            { 
                return _shapes.Count; 
            }
        }

        public Color Background
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }

        public void RemoveShape()
        {
            foreach (Shape s in _shapes.ToList())
            {
                if (s.Selected)
                {
                    _shapes.Remove(s);
                }

            }
        }

        public void Draw()
        {
            SplashKit.ClearScreen(_background);
            foreach (Shape s in _shapes)
            {
                s.Draw();
            }
        } 



        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (!s.Selected)
                {
                    s.Selected = s.IsAt(pt);
                }
                else
                {
                    s.Selected = !s.IsAt(pt);
                }
            }
        }

        public List<Shape> SelectedShapes
        {
            get
            {
                List<Shape> result = new List<Shape>();
                foreach (Shape s in _shapes)
                {
                    if (s.Selected)
                    {
                        result.Add(s);
                    }
                }
                return result;
            }
        }
    }
}
