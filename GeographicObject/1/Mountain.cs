using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{    
    class Mountain : Geographic_object
    {
        double theHighestPoint;
        public double TheHighestPoint { get { return theHighestPoint; } set { theHighestPoint = value; } }
        public Mountain() : base() { }
        public Mountain(double x, double y, string name, string description, double theHighestPoint) : base(x, y, name, description)
        {
            this.theHighestPoint = theHighestPoint;
        }

        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("The Highest point is ", theHighestPoint);
        }
    }
}
