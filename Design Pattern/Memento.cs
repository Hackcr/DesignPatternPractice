using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Memento
    {

        public class A
        {
            public string P1 { get; set; }
            public string P2 { get; set; }
            public string P3 { get; set; }


            public M SetM()
            {
                return new M() { P1 = P1, P2 = P2, P3 = P3 };
            }

            public void GetM(M m)
            {
                this.P1 = m.P1;
                this.P2 = m.P2;
                this.P3 = m.P3;
            }
        }


        public class M
        {
            public string P1 { get; set; }
            public string P2 { get; set; }
            public string P3 { get; set; }
        }


        public void Use()
        {
            A a = new A();
            a.P1 = "P1";
            a.P2 = "P2";
            a.P3 = "P3";

            M m = a.SetM();
            a = new A();
            a.GetM(m);


        }

    }
}
