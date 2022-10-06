using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject2
{
    public class Mountain : IGeographicalObject
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public double TheHighestPoint { get; set; }

        public void displayInformation()
        {
            Console.WriteLine("Mountain's coordinates are X = " + X + " Y = " + Y);
            Console.WriteLine("The name of the mountain is " + Name);
            Console.WriteLine("It is " + Description);
            Console.WriteLine("Its Highest point is " + TheHighestPoint);
        }
        public void setInformation(double x, double y, string name, string description,
                           double point)
        {
            X = x;
            Y = y;
            Name = name;
            Description = description;
            TheHighestPoint = point;
        }
    }
}
