using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Decorator
    {

        public abstract class A
        {
            public abstract string GetStr();
        }

        public class B : A
        {
            public override string GetStr()
            {
                return "B";
            }
        }

        public abstract class D : A
        {
            protected A a;

            public D(A a)
            {
                this.a = a;
            }
        }


        public class D1 : D
        {
            public D1(A a) : base(a)
            {
            }

            public override string GetStr()
            {
                return base.a.GetStr() + "D1";
            }

        }

        public class D2 : D
        {
            public D2(A a) : base(a)
            {
            }

            public override string GetStr()
            {
                return base.a.GetStr() + "D2";
            }
        }

        public void Use()
        {
            A a = new B();
            a = new D1(a);
            a = new D2(a);
            a.GetStr();

        }
    }
}
