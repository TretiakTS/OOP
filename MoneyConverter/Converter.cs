using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConvertation
{
    internal class Converter
    {
        private readonly decimal dollarRate;
        private readonly decimal euroRate;
        public Converter(decimal dollar, decimal euro)
        {
            this.dollarRate = dollar;
            this.euroRate = euro;
        }
        public double ConvertHryvniaToDollar(double hryvny)
            => hryvny / Convert.ToDouble(dollarRate);

        public double ConvertHryvniaToEuro(double hryvny)
            => hryvny / Convert.ToDouble(euroRate);
        public double ConvertDollarToHryvnia(double dollar)
            => Convert.ToDouble(dollarRate) * dollar;
        public double ConvertEuroToHryvnia(double euro)
            => Convert.ToDouble(euroRate) * euro;
    }
}
