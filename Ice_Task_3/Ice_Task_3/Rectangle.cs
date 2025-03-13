using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Rectangle : shapes, iCalculateArea

    {
       

        // Create properties Length and Width
        public int Length { get; set; }
        public int Width { get; set; }

        // Create constructor
        public Rectangle(string name,int length,int width) : base(name)
        {
            Length = length;
            Width = width;
        }

        // calculate area

        public void calculateArea()
        {
            Console.WriteLine($"Area of Rectangle: {Length*Width} squared");
        }


    }
}
