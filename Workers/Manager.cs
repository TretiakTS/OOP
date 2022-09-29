using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    class Manager : Worker
    {
        private Random rnd;
        public Manager(string Name) : base(Name)
        {
            Position = "Manager";
        }
        public override void FillWorkDay()
        {
            int value;
            value = rnd.Next(1, 10);
            for (int i = 0; i < value; i++)
            {
                Call();
            }
            Relax();
            value = rnd.Next(1, 5);
            for (int i = 0; i < value; i++)
            {
                Call();
            }
        }
    }
}
