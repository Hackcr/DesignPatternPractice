using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Composite
    {

        public class A
        {
            public List<A> AList { get; set; }

            public void Add(A a)
            {
                AList.Add(a);
            }

            public void Remove(A a)
            {
                AList.Remove(a);
            }
        }


        public void Use()
        {
            A a = new A();
            a.Add(new A());
            a.Add(a.AList.First());
        }

    }
}
