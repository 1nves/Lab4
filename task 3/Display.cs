using System;

namespace task_3
{
    internal class Display : LaptopParametrs
    {
        public enum BrandOfParametDisp
        {
            Lenovo,
            HP,
            Apple
        }

        private BrandOfParametDisp brand;

        public BrandOfParametDisp Brand { get { return brand; } }

        public Display (string _parametr1, double _parametr2, string _parametr3, BrandOfParametDisp brand) : base (_parametr1, _parametr2, _parametr3) 
        {
            this.brand = brand;
        }
    }
}
