using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
   public class Animal : ISerializable
    {
        public string Kind { get; set; }
        public string Color { get; set; }
        public short Age { get; set; }

        public Animal(string kind, string color, short age)
        {
            Kind = kind;
            Color = color;
            Age = age;
        }

        public Animal (SerializationInfo propertyBag, StreamingContext context)
        {
            Kind = propertyBag.GetString("Kind");
            Color = propertyBag.GetString("Color");
            Age = propertyBag.GetInt16("Age");
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Kind", Kind);
            info.AddValue("Color", Color);
            info.AddValue("Age", Age);
        }
    }
}
