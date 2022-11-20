using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Processor : LaptopParametrs
    {
        public enum BrandOfParametrProc
        {
            Lenovo,
            HP,
            Apple
        }

        private BrandOfParametrProc brand;

        public BrandOfParametrProc Brand { get { return brand; } }

        public Processor (string _parametr1, double _parametr2, string _parametr3, BrandOfParametrProc brand) : base (_parametr1, _parametr2, _parametr3) 
        {
            this.brand = brand;
        }
    }
}
