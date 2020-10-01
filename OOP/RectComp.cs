using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {

    class RectComp {

        private Quad quad { get; set; }

        public int Perimeter() {
            return this.quad.Perimeter();
        }

        public int Area() {
            return this.quad.Side1 * this.quad.Side2;
        }

        public RectComp(int Side1, int Side2) {
            this.quad = new Quad(Side1, Side2, Side1, Side2);
        }
    }
}
