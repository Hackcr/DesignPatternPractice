using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class Flyweight
    {
        public class B
        {
            public string GetStr()
            {
                return "B";
            }
        }

        public class A
        {
            private Hashtable hashtable = new Hashtable();

            public object GetObj(string key)
            {
                if (hashtable.ContainsKey(key))
                {
                    if (hashtable[key] == null)
                    {
                        hashtable[key] = new B();
                    }
                }
                else
                {
                    hashtable.Add(key, new B());
                }
                return hashtable[key];
            }
        }

        public void Use()
        {
            B b = (B)new A().GetObj("B");


        }


    }
}
