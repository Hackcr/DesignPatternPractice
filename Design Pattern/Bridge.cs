using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Bridge
    {

        public interface I
        {
            string GetStr();
        }

        public class A : I
        {
            public string GetStr()
            {
                return "A";
            }
        }

        public class C : I
        {
            public string GetStr()
            {
                return "C";
            }
        }


        public class B
        {
            private I i;
            public void GetI(I i)
            {
                this.i = i;
            }

            public string Get()
            {
                return i.GetStr();
            }

        }


        public string Use()
        {
            B b = new B();
            b.GetI(new A());
            return b.Get();

            b.GetI(new C());
            b.Get();
        }




    }
}
