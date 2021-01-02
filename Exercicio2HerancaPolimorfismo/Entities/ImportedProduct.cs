using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2HerancaPolimorfismo.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee) 
            : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} $ {TotalPrice().ToString("F2",CultureInfo.InvariantCulture)}");
            sb.Append($" (Customs fee: $ {CustomsFee.ToString("F2",CultureInfo.InvariantCulture)})");
            return sb.ToString();
        }

        public double TotalPrice()
        {
            Price += CustomsFee;
            return Price;
        }
    }
}
