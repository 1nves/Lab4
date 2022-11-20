using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class LaptopParametrs 
    {
        private string _parametr1;
        private double _parametr2;
        private string _parametr3;

        public string Parametr1 { get { return _parametr1; } }
        public double Parametr2 { get { return _parametr2; } }  
        public string Parametr3 { get { return _parametr3; } }

        public LaptopParametrs(string _parametr1, double _parametr2, string _parametr3 )
        {
            this._parametr1 = _parametr1;
            this._parametr2 = _parametr2;
            this._parametr3 = _parametr3;
        }
    }
}
