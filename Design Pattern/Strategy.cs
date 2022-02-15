using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Strategy
    {
        public class C
        {
            S s;
            public C(S s)
            {
                this.s = s;
            }

            public string GetStr()
            {
                return s.GetStr();
            }

        }

        public abstract class S
        {
            public abstract string GetStr();
        }

        public class A : S
        {
            public override string GetStr()
            {
                return "A";
            }
        }

        public class B : S
        {
            public override string GetStr()
            {
                return "B";
            }
        }

        public void Use()
        {
            C c = new C(new A());
            c.GetStr();
        }

    }
}
