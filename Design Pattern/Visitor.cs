using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Visitor
    {
        public abstract class V
        {
            public abstract void VisitE1(E1 e);
            public abstract void VisitE2(E2 e);
        }

        public class V1 : V
        {
            public override void VisitE1(E1 e)
            {
                throw new NotImplementedException();
            }

            public override void VisitE2(E2 e)
            {
                throw new NotImplementedException();
            }
        }

        public class V2 : V
        {
            public override void VisitE1(E1 e)
            {
                throw new NotImplementedException();
            }

            public override void VisitE2(E2 e)
            {
                throw new NotImplementedException();
            }
        }



        public abstract class E
        {
            public abstract void Accept(V v);
        }

        public class E1 : E
        {
            public override void Accept(V v)
            {
                v.VisitE1(this);
            }
        }

        public class E2 : E
        {
            public override void Accept(V v)
            {
                v.VisitE2(this);
            }
        }


        public void Use() 
        {
            E1 e1 = new E1();
            e1.Accept(new V1());
            E2 e2 = new E2();
            e2.Accept(new V2());

        }

    }
}
