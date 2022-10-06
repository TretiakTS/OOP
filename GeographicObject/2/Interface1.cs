using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeographicObject2
{
    
    internal interface IGeographicalObject
    {
        double X { get; set; }
        double Y { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        virtual void displayInformation() { }
        public void setInformation(double x, double y, string name, string description)
        {
        }

    }
}
