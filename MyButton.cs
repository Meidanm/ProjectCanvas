using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    
     class MyButton
    {
        protected Point _topLeft, _bottomRight;
        private int _width, _height;

        internal MyButton(Point topLeft, Point bottomRight)
        {
            this._topLeft = topLeft;
            this._bottomRight = bottomRight;
        }

        internal int GetWidth()
        {
            return this._width;
        }

        internal int GetHeight()
        {
            return this._height;
        }

        internal bool SetTopLeft(Point topLeft)
        {
            if (!(topLeft.GetX() > this._bottomRight.GetX() && topLeft.GetY() < this._bottomRight.GetY()))
            {
                this._topLeft = topLeft;
                this._width = topLeft.GetX();
                this._height = topLeft.GetY();
                return true;
            }
            else
                return false;
        }

        internal bool SetBottomRight(Point bottomRight)
        {
            if (!(bottomRight.GetX() < this._topLeft.GetX() && bottomRight.GetY() > this._topLeft.GetY()))
            {
                this._bottomRight = bottomRight;
                
                
                
                return true;
            }
            else
                return false;
        }

        internal Point GetTopLeft()
        {
            return this._topLeft;
        }

        internal Point GetBottomRight()
        {
            return this._bottomRight;
        }

        private void UpDateWeidthAndHeight()
        {
            this._width = _bottomRight.GetX() - _topLeft.GetX();
            this._height = _topLeft.GetY() - _bottomRight.GetY();


            this
        }
        public override string ToString()
        {
            return ($"TOP LEFT: {this._topLeft.GetX()}, {this._topLeft.GetY()}/n BOTTOM RIGHT: {this._bottomRight.GetX()}, {this._bottomRight.GetY()}/n HEIGHT: {this._height}/n WIDTH: {this._width}");
        }

    }
}
