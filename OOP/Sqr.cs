using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {

    class Sqr : Rect, IGeometricShape {

        public override string WhatAmI() {
            return "Square";
        }

        public Sqr(int Side) : base(Side, Side) {
        }
        public Sqr() {
        }
    }
}
