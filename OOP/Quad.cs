using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {

    class Quad {

        protected int Side1 { get; set; }
        protected int Side2 { get; set; }
        protected int Side3 { get; set; }
        protected int Side4 { get; set; }

        public virtual string WhatAmI() {
            return "Quadrillateral";
        }

        public int Perimeter() {
            return Side1 + Side2 + Side3 + Side4;
        }

        public virtual int Area() {
            throw new NotImplementedException();
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
