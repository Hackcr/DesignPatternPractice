using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class FactoryMethod
    {
        interface I
        {
            A GetA(string name);
        }

        public class F1 : I
        {
            public A GetA(string name)
            {
                if (name == "B")
                {
                    return new B();
                }
                else if (name == "B1")
                {
                    return new B1();
                }
                else
                {
                    return null;
                }
            }
        }
        public class F2 : I
        {
            public A GetA(string name)
            {
                if (name == "C")
                {
                    return new C();
                }
                else if (name == "C1")
                {
                    return new C1();
                }
                else
                {
                    return null;
                }
            }
        }


        public class A
        {
            public virtual string GetStr()
            {
                return "A";
            }
        }
        public class B : A
        {
            public override string GetStr()
            {
                return "B";
            }
        }
        public class C : A
        {
            public override string GetStr()
            {
                return "C";
            }
        }
        public class B1 : A
        {
            public override string GetStr()
            {
                return "B1";
            }
        }
        public class C1 : A
        {
            public override string GetStr()
            {
                return "C1";
            }
        }



        public void Use()
        {
            I i1 = new F1();
            A b = i1.GetA("B");
            b.GetStr();
            A b1 = i1.GetA("B1");
            b1.GetStr();

            I i2 = new F1();
            A c = i2.GetA("C");
            c.GetStr();
            A c1 = i2.GetA("C1");
            c1.GetStr();
        }


    }

}
