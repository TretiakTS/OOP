using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject
{
    class River : Geographic_object
    {
        private double speed;
        private double length;
        public double Speed
        {
            get { return speed; }
            set { speed = value; }
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public River() : base() { }
        public River(double x, double y, string name, string description, double speed, double length) : base(x, y, name, description)
        {
            this.speed = speed;
            this.length = length;
        }
        public override void DisplayInformation()
        {
            base.DisplayInformation();
            Console.WriteLine("The speed is " + speed);
            Console.WriteLine("The length is " + length);
        }
    }
}
