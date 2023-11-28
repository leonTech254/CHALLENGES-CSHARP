using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
Inheritance:CHALLANGE 2
Implement a base class "Shape" and derive classes like Circle, Rectangle, and Triangle. 
Add methods to calculate the area and perimeter for each shape.
*/
namespace AdvanceC_Sharp
{
	public class Shape
	{
		private double width;
		private double height;

		public Shape(double width, double height)
		{
		Width = width;
		Height = height;
		}


		public double Width
		{
			get { return width; }
			set { width = value; }
		}

		public double Height
		{
			get { return height; }
			set { height = value; }
		}


	}

	public class Rectangle : Shape
	{
		public Rectangle(double width, double height) : base(width, height) { 
		
		
		}

		public void calculateRectangleArea()
		{
			/*Calculating the Area of the rectangle*/
			double area = Width * Height;
			Console.WriteLine($"The Area of the Rectangle is {area}");

		}

		public void calculateParameter()
		{
			double paremeter=2*(Width + Height);
			Console.WriteLine($"The parater of the rectangle is {paremeter}");
		}
	}



}
