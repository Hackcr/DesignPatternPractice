using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Mediator
    {
        public abstract class M
        {
            public abstract void Send(C c);
        }

        public class M1 : M
        {
            C1 c1;
            C2 c2;

            public void SetC(C1 c1, C2 c2)
            {
                this.c1 = c1;
                this.c2 = c2;
            }

            public override void Send(C c)
            {
                if (c1 == c)
                {
                    c2.Notify();
                }
                else
                {
                    c1.Notify();
                }
            }
        }

        public abstract class C
        {
            protected M m;
            public C(M m)
            {
                this.m = m;
            }
        }

        public class C1 : C
        {
            public C1(M m) : base(m)
            {
            }


            public void Send(C c)
            {
                m.Send(c);
            }

            public void Notify()
            {

            }

        }

        public class C2 : C
        {
            public C2(M m) : base(m)
            {
            }

            public void Send(C c)
            {
                m.Send(c);
            }


            public void Notify()
            {

            }
        }

        public void Use()
        {
            M1 m = new M1();
            C1 c1 = new C1(m);
            C2 c2 = new C2(m);
            m.SetC(c1, c2);
            c1.Send(c2);
            c2.Send(c1);



        }



    }
}
