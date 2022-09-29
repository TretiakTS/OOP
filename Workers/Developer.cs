using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Developer : Worker
    {
        public Developer(string Name) : base(Name)
        {
            Position = "Developer";
        }
        public override void FillWorkDay()
        {
            WriteCode();
            Call();
            Relax();
            WriteCode();
        }
    }
}
