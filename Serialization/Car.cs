using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Car
    {
        public string Model { get; set; }
        public string color { get; set; }
        public decimal Price { get; set; }

        public Car(string model, string color, decimal price)
        {
            Model = model;
            this.color = color;
            Price = price;
        }
    }
}
