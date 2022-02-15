using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Facade
    {
        public class A
        {
            public string GetStr()
            {
                return "A";
            }
        }


        public class B
        {
            public string GetStr()
            {
                return "B";
            }
        }

        public class C
        {
            public string GetStr()
            {
                return "C";
            }
        }


        public class D
        {
            A a = new A();
            B b = new B();
            C c = new C();

            public string GetStr1()
            {
                return a.GetStr() + b.GetStr();
            }

            public string GetStr2()
            {
                return c.GetStr();
            }

        }



        public void Use()
        {
            D d = new D();
            d.GetStr1();
            d.GetStr2();

        }


    }
}
