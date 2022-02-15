namespace Design_Pattern
{
    internal class SimpleFactory
    {

        public class A
        {
            public virtual string GetStr()
            {
                return "A";
            }
        }
        public class B : A
        {
            public override string GetStr()
            {
                return "B";
            }
        }
        public class C : A
        {
            public override string GetStr()
            {
                return "C";
            }
        }

        public class F
        {
            public static A Get(string name)
            {
                if (name == "B")
                {
                    return new B();
                }
                else if (name == "C")
                {
                    return new C();
                }
                else
                {
                    throw new NullReferenceException();
                }
            }
        }

        public void Use()
        {
            A b = F.Get("B");
            b.GetStr();
            A c = F.Get("C");
            c.GetStr();
        }

    }

}
