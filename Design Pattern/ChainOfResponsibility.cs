using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class ChainOfResponsibility
    {

        public abstract class R
        {
            protected R r;
            public void SetR(R r)
            {
                this.r = r;
            }
            public abstract string Excute();
        }

        public class A : R
        {

            public override string Excute()
            {
                string str = "A";
                if (r.Excute() != null)
                {
                    str += r.Excute();
                }
                return str;
            }
        }
        public class B : R
        {

            public override string Excute()
            {
                string str = "B";
                if (r.Excute() != null)
                {
                    str += r.Excute();
                }
                return str;
            }
        }
        public class C : R
        {
            public override string Excute()
            {
                string str = "C";
                if (r.Excute() != null)
                {
                    str += r.Excute();
                }
                return str;
            }
        }


        public void Use()
        {
            R r1 = new A();
            R r2 = new B();
            R r3 = new C();
            r1.SetR(r2);
            r2.SetR(r3);

            r1.Excute();
        }

    }
}
