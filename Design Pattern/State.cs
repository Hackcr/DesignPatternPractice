using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class State
    {
        public class C
        {
            public S S { get; set; }
        }

        public abstract class S
        {
            public abstract string H(C c);
        }

        public class S1 : S
        {
            public override string H(C c)
            {
                return c.S + "S1";
            }
        }

        public class S2 : S
        {
            public override string H(C c)
            {
                return c.S + "S2";
            }
        }


        public void Use()
        {
            C c = new C();
            S1 s1 = new S1();
            s1.H(c);
            S2 s2 = new S2();
            s2.H(c);
        }


    }
}
