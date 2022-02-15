using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class AbstractFactory
    {

        public abstract class A
        {
            public virtual string GetStr()
            {
                return "A";
            }
        }


        public abstract class B
        {
            public virtual string GetStr()
            {
                return "A";
            }
        }


        public class A1 : A
        {
            public override string GetStr()
            {
                return "B";
            }
        }
        public class A2 : A
        {
            public override string GetStr()
            {
                return "C";
            }
        }
        public class B1 : B
        {
            public override string GetStr()
            {
                return "B1";
            }
        }
        public class B2 : B
        {
            public override string GetStr()
            {
                return "C1";
            }
        }


        public abstract class F
        {
            public abstract A CreateA();

            public abstract B CreateB();
        }


        public class F1 : F
        {
            public override A CreateA()
            {
                return new A1();
            }

            public override B CreateB()
            {
                return new B1();
            }
        }

        public class F2 : F
        {
            public override A CreateA()
            {
                return new A2();
            }

            public override B CreateB()
            {
                return new B2();
            }
        }

        public class U
        {
            private A a;
            private B b;
            private F f;
            public U(F f)
            {
                this.f = f;
            }

            public void Run()
            {
                a = f.CreateA();
                b = f.CreateB();
            }

        }


        public void Use()
        {
            U u1 = new U(new F1());
            u1.Run();


            U u2 = new U(new F2());
            u2.Run();
        }


    }
}
