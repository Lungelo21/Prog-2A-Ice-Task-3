using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ice_Task_3
{
    class shapes 
    {
        //Property
        public string Name { get; set; }
        
        // Create constructor
        public shapes(string name)
        {
            Name = name;
        }
        

        public virtual void Display()
        {
            Console.WriteLine("This method will be overriden");
        }
    }
}
