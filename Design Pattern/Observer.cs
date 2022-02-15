using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Observer
    {

        public abstract class N
        {
            private List<O> oList = new List<O>();

            public void Add(O o)
            {
                oList.Add(o);
            }

            public void Remove(O o)
            {
                oList.Remove(o);
            }

            public void Notify()
            {
                foreach (var o in oList)
                {
                    o.Update();
                }
            }
        }

        public class N1 : N
        {
            public string State { get; set; }
        }



        public abstract class O
        {
            public abstract string Update();
        }

        public class O1 : O
        {
            private N1 n1;

            public O1(N1 n1)
            {
                this.n1 = n1;
            }

            public override string Update()
            {
                return n1.State;
            }
        }

        public class O2 : O
        {
            private N1 n1;

            public O2(N1 n1)
            {
                this.n1 = n1;
            }

            public override string Update()
            {
                return n1.State;
            }
        }




        public void Use()
        {
            N1 n1 = new N1();
            n1.Add(new O1(n1));
            n1.Add(new O2(n1));

            n1.Notify();

        }
    }
}
