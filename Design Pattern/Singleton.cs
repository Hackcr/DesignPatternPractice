using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Singleton
    {

        public class A
        {
            private static readonly object obj = new object();
            private static A a;

            private A() { }

            public static A GetA()
            {
                if (a == null)
                {
                    lock (obj)
                    {
                        if (a == null)
                        {
                            a = new A();
                        }
                    }
                }
                return a;

            }
        }

        public class B
        {
            private static readonly object obj = new object();
            private static readonly B b = new B();

            private B() { }

            public static B GetB()
            {
                return b;
            }

        }

        public void Use()
        {
            A a = A.GetA();
            B b = B.GetB();
        }

    }
}
