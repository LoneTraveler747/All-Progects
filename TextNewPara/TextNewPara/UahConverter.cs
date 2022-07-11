using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextNewPara
{
    public class UahConverter : AbstractConverter
    {
        readonly double rur, usd, eur;

        double uahValue;

        Currency outputCurrency;

        public UahConverter(double rur, double eur, double usd) 
            :base(Currency.UAH)
        {
            if (rur <= 0 || eur <= 0 || usd <= 0)
            {
                throw new ArgumentException("Error");
            }

            this.rur = rur;
            this.usd = usd;
            this.eur = eur;
        }

        public override Currency OutputCurrency
        {
            get { return outputCurrency; }
            set { outputCurrency = value; }
        }

        public override double Value
        {
            get
            {
                switch (outputCurrency)
                {
                    case Currency.EUR:
                        return uahValue / eur;
                        break;
                    case Currency.RUR:
                        return uahValue / rur;
                        break;
                    case Currency.UAH:
                        return uahValue;
                        break;
                    case Currency.USD:
                        return uahValue / usd;
                        break;

                    default:
                        throw new Exception();
                }
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Value");
                }
                this.uahValue = value;
            }
        }

    }
}
