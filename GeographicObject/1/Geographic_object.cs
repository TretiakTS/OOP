using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{
    abstract class Geographic_object
    {
        private double x;
        private double y;
        public double X
        {
            get { return x; }

            set { x = value; }
        }
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value;}
        }
        public Geographic_object() { }
        public Geographic_object(double x, double y, string name, string description)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.description = description;
        }
        private string description;
        public string Description { get { return description; } set { description = value; } }
        public virtual void DisplayInformation()
        {
            Console.WriteLine("The coordinates are X = " + X + " Y = " + y);
            Console.WriteLine("The name of object is " + Name);
            Console.WriteLine("It is " + description);
        }
    }
}
