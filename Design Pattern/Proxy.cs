using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Proxy
    {

        interface I
        {
            public string GetStrA();
            public string GetStrB();
            public string GetStrC();
        }

        public class A
        {
            public string GetStrA()
            {
                return "A";
            }
        }

        public class B : A, I
        {
            public string GetStrB()
            {
                return "B";
            }

            public string GetStrC()
            {
                return "C";
            }
        }

        public class C : I
        {
            A a = new A();
            public string GetStrA()
            {
                return a.GetStrA();
            }

            public string GetStrB()
            {
                return "B";
            }

            public string GetStrC()
            {
                return "C";
            }
        }

        public void Use()
        {
            I a = new B();
            a.GetStrA();
            a.GetStrB();
            a.GetStrC();

            I b = new C();
            b.GetStrA();
            b.GetStrB();
            b.GetStrC();
        }



    }
}
