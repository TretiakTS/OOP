using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workers;

namespace Workers
{
    abstract class Worker
    {
        public string Name;
        public string Position;
        public string WorkDay;
        public Worker(string Name)
        {
            this.Name = Name;
        }
        public void Call()
        {
            Console.WriteLine("Calling");
        }
        public void WriteCode()
        {
            Console.WriteLine("Writing code");
        }
        public void Relax()
        {
            Console.WriteLine("Relaxing");
        }
        public abstract void FillWorkDay();

    }
}
