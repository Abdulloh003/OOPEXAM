﻿using System;
System.Console.WriteLine("Circle");
var circle = new Circle();
circle.SetRadius(15);
System.Console.Write("Area =  ");
System.Console.WriteLine(circle.GetArea());
System.Console.Write("Perimeter = ");
System.Console.WriteLine(circle.GetPerimeter());
circle.ToString();
System.Console.WriteLine();
System.Console.WriteLine("Rectangle");
var rectangle = new Rectange();
rectangle.SetWidth(15);
rectangle.SetHeight(10);
System.Console.Write("Area =  ");
System.Console.WriteLine(rectangle.GetArea());
System.Console.Write("Perimeter = ");
System.Console.WriteLine(rectangle.GetPerimeter());
rectangle.ToString();
System.Console.WriteLine();
System.Console.WriteLine("Square");
var square = new Square();
square.SetSide(20);
System.Console.Write("Area =  ");
System.Console.WriteLine(square.GetArea());
System.Console.Write("Perimeter = ");
System.Console.WriteLine(square.GetPerimeter());
square.ToString();