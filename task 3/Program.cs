using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Program
    {
        private static RAM ram = new RAM
            ("DDR4", 16, "Kingston", RAM.BrandOfParametrRam.Lenovo);

        private static Processor processor = new Processor
            ("AMD", 8, "Zen 3", Processor.BrandOfParametrProc.HP);

        private static Display display = new Display
            ("IPS", 15.6, "FULL_HD", Display.BrandOfParametDisp.Apple);

        private static Laptop laptop = new Laptop(ram,processor,display);

        static void Main(string[] args)
        {
            laptop.Print();
            Console.ReadLine();
        }
    }
}
