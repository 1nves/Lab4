using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class RAM : LaptopParametrs
    {
        public enum BrandOfParametrRam
        {
            Lenovo,
            HP,
            Apple
        }

        private BrandOfParametrRam brand;

        public BrandOfParametrRam Brand { get { return brand; } }

        public RAM (string _parametr1, double _parametr2, string _parametr3, BrandOfParametrRam brand) : base (_parametr1, _parametr2, _parametr3) 
        {
            this.brand = brand;
        }
    }
}
