using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialization
{
   public class Drink
    {
        [XmlAttribute("NameDrink")]
        public string Name { get; set; }

        [XmlAttribute("PriceDrink")]
        public int Price { get; set; }

        public Drink(string name, int price)
        {
            Name = name;
            Price = price;
        }

        public Drink()
        {
        }
    }
}
