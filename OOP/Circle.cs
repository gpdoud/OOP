using System;
using System.Collections.Generic;
using System.Text;

namespace OOP {
    class Circle : IGeometricShape {

        private const double PI = 3.14;
        public double radius { get; private set; }

        public int Area() {
            return Convert.ToInt32(PI * this.radius * this.radius);
        }

        public int Perimeter() {
            return Convert.ToInt32(2 * PI * this.radius);
        }

        public Circle(double radius) {
            this.radius = radius;
        }
    }
}
