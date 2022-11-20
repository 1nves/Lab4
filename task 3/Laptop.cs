using System;
using System.ComponentModel;

namespace task_3
{
    internal class Laptop
    {
        private RAM rams;
        private Processor processors;
        private Display displays;

        public Laptop (RAM rams, Processor processor, Display displays)
        {
            this.rams = rams;
            this.processors = processor;
            this.displays = displays;
        }

        public void Print()
        {
            Console.WriteLine("RAM:");
            Parametrs(rams);
            Console.WriteLine("Processor:");
            Parametrs(processors); 
            Console.WriteLine("Display:");
            Parametrs(displays);
        }

        public void Parametrs(Object obj)
        {
            foreach (PropertyDescriptor parametr in TypeDescriptor.GetProperties(obj))
            {
                string name = parametr.Name;
                object value = parametr.GetValue(obj);
                Console.WriteLine($"{name}={value}");
            }
            Console.WriteLine(" ");
        }
    }
}
