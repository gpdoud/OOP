using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {

    class Quad : IPerimeter, IArea {

        public double Side1 { get; private set; }
        public double Side2 { get; private set; }
        public double Side3 { get; private set; }
        public double Side4 { get; private set; }

        public virtual string WhatAmI() {
            return "Quadrillateral";
        }

        public double Perimeter() {
            return Side1 + Side2 + Side3 + Side4;
        }

        public Quad(int S1, int S2, int S3, int S4) {
            this.Side1 = S1;
            this.Side2 = S2;
            this.Side3 = S3;
            this.Side4 = S4;
        }

        public Quad() {

        }
    }
}
