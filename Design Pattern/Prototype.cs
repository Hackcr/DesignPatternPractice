using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Design_Pattern
{
    internal class Prototype
    {

        public class A
        {
            public string Name = "aaa";
        }

        public void Use()
        {
            A a = new A();
            var b = JsonSerializer.Deserialize<A>(JsonSerializer.Serialize(a));

            
        }
    }
}
