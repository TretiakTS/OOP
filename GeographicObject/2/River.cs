using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject2
{
    public class River : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Speed { get; set; }
        public double Length { get; set; }

        public void setInformation(double x, double y, string name, string description,
                            double speed, double length)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            Speed = speed;
            Length = length;
        }
        public void displayInformation()
        {
            Console.WriteLine("Rivers coordinates are X = " + X + " Y = " + Y);
            Console.WriteLine("The name of the river is " + Name);
            Console.WriteLine("It is " + Description);
            Console.WriteLine("River's speed is " + Speed);
            Console.WriteLine("River's length is " + Length);
        }
    }
}
