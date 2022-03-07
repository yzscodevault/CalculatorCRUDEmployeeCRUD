using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5._1
{
    enum Operator
    {
        Addition,
        Substraction,
        Muplication,
        Division
    }

    interface ICalculator
    {
        decimal FstNum { get; set; }
        Operator Operation { get; set; }
        decimal ScdNum { get; set; }
        decimal Result { get; set; }
        void testInterface();
    }

    class CalculatorClass: ICalculator
    {
        public decimal FstNum { get; set; }
        public Operator Operation { get; set; }
        public decimal ScdNum { get; set; }
        public decimal Result { get; set; }

        public void testInterface()
        {
            throw new NotImplementedException();
        }
    }
}
