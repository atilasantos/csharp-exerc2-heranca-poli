using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio2HerancaPolimorfismo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Name} $ {Price.ToString("F2",CultureInfo.InvariantCulture)}");
            return sb.ToString();
        }
    }
}
