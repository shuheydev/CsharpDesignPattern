using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFactory
{
    interface IDoor
    {
        float GetWidth();
        float GetHeight();
    }
    class WoodenDoor : IDoor
    {
        private float _width;
        private float _height;

        public WoodenDoor(float width, float height)
        {
            _width = width;
            _height = height;
        }

        public float GetHeight()
        {
            return this._height;
        }

        public float GetWidth()
        {
            return this._width;
        }
    }
}
