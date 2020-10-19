using System;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.IO;

namespace OOP {

    class Program {
    
        static void Main(string[] args) {

            var rectComp = new RectComp(3, 9);
            Console.WriteLine($"The Perimeter of the rectComp is {rectComp.Perimeter()}");
            Console.WriteLine($"The Area of the rectComp is {rectComp.Area()}");

            Rect fred = new Rect(7, 11);
            Console.WriteLine($"Fred is a {fred.WhatAmI()}");

            Sqr sqr1 = new Sqr(4);
            Console.WriteLine($"The Perimeter of the sqr is {sqr1.Perimeter()}");
            Console.WriteLine($"The Area of the sqr is {sqr1.Area()}");
            Console.WriteLine($"The sqr1 is a {sqr1.WhatAmI()}");

            var rect1 = new Rect(5, 3);
            //int p = rect1.Perimeter();
            Console.WriteLine($"The Perimeter of the rect is {rect1.Perimeter()}");
            Console.WriteLine($"The Area of the rect is {rect1.Area()}");
            Console.WriteLine($"The rect1 is a {rect1.WhatAmI()}");

            var quad1 = new Quad(3, 4, 5, 6);
            Console.WriteLine($"The Perimeter of the quad is {quad1.Perimeter()}");
            Console.WriteLine($"The quad1 is a {quad1.WhatAmI()}");

            var collection = new Quad[] {
                fred, sqr1, rect1, quad1
            };
            foreach(var geo in collection) {
                Console.WriteLine($"geo is a {geo.WhatAmI()}");
                var rect = geo as Rect;
                if(rect != null) {
                    Console.WriteLine($"The area of geo is {rect.Area()}");
                }
            }

            var geoshapes = new IGeometricShape[] {
                new Circle(1), new Circle(2), new Rect(3, 7), new Sqr (5)
            };
            //var geoshapes2 = new IGeometricShape[2];
            //geoshapes2[0] = new Circle(3);
            //geoshapes2[1] = new Circle(4);

            foreach(var shape in geoshapes) {
               
                Console.WriteLine($"Perimeter: {shape.Perimeter()}, Area: {shape.Area()}");
            }

        }
    }
}
