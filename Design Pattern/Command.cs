using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Command
    {

        public abstract class C
        {
            protected R r;
            public C(R r)
            {
                this.r = r;
            }

            public abstract void Execute();
        }

        public class C1 : C
        {
            public C1(R r) : base(r)
            {
            }

            public override void Execute()
            {
                r.GetStr();
            }
        }

        public class R
        {
            public string GetStr()
            {
                return "R";
            }
        }

        public class V
        {
            C c;
            public void SetC(C c)
            {
                this.c = c;
            }

            public void ExecuteCommand()
            {
                c.Execute();
            }
        }

        public void Use()
        {
            C c = new C1(new R());

            V v = new V();
            v.SetC(c);
            v.ExecuteCommand();
        }



    }
}
