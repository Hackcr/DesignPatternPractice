using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Interpreter
    {

        public abstract class I
        {
            public abstract void Interpret(C c);
        }

        public class I1 : I
        {
            public override void Interpret(C c)
            {
                c.Content.Replace("", "");
            }
        }

        public class I2 : I
        {
            public override void Interpret(C c)
            {
                c.Content.Replace("", "");
            }
        }

        public class C
        {
            public string Content { get; set; }
        }


        public void Use()
        {
            C c = new C();
            List<I> list = new List<I>
            {
                new I1(),
                new I2()
            };

            foreach (var item in list)
            {
                item.Interpret(c);
            }
        }


    }
}
