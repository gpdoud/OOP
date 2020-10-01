using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {

    class Rect : Quad {

        public double Area() {
            return Side1 * Side2;
        }
        public int AreaToInt() {
            return (int)Area();
        }

        public override string WhatAmI() {
            return "Rectangle";
        }

        public Rect(int Side1, int Side2) : base(Side1, Side2, Side1, Side2) {
        }
        public Rect() {

        }
    }
}
