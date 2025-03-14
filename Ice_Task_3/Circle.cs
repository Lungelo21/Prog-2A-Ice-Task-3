using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class Circle : shapes, iCalculateArea
    {
        // Create Radius property
        public double Radius { get; set; }

        // Create constru
        public Circle(string name,int radius) : base(name)
        {
            Radius = radius;
        }
        
        //  Calc area

        public void calculateArea()
        {
            Console.WriteLine($"Area of a cirle: {(Radius*Radius)*Math.PI:F2}");
        }

        public override void Display()
        {
            Console.WriteLine($"Circle Details: \n");
        }


    }
}
