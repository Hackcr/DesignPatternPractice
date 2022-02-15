using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Builder
    {

        public class A
        {
            public string P1 { get; set; }
            public string P2 { get; set; }
            public string P3 { get; set; }
        }

        public class B
        {
            public string P1 { get; set; }
            public string P2 { get; set; }
            public string P3 { get; set; }


            public B SetP1(string p)
            {
                P1 = p;
                return this;
            }

            public B SetP2(string p)
            {
                P2 = p;
                return this;
            }

            public B SetP3(string p)
            {
                P3 = p;
                return this;
            }

            public A Build()
            {
                return new A()
                {
                    P1 = this.P1,
                    P2 = this.P2,
                    P3 = this.P3,
                };
            }

        }



        public void Use()
        {
            A a = new B()
                .SetP1("")
                .SetP2("")
                .SetP3("")
                .Build();

        }




    }
}
