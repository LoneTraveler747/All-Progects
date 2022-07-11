using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNewPara
{
    public abstract class AbstractConverter
    {
        Currency inputCurrency;
        public Currency InputCurrency { get { return InputCurrency; } }

        public abstract Currency OutputCurrency { get; set; }

        public abstract double Value { get; set; }

        public AbstractConverter(Currency inputCurrency)
        {
            this.inputCurrency = inputCurrency;
        }
    }
}
