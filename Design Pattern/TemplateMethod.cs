using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern
{
    internal class TemplateMethod
    {

        public abstract class T
        {
            public abstract string GetStr1();
            public string GetStr2()
            {
                return "Str2";
            }
            public abstract string GetStr3();

            public void Run()
            {
                GetStr1();
                GetStr2();
                GetStr3();
            }

        }

        public class T1 : T
        {
            public override string GetStr1()
            {
                return "Str1";
            }

            public override string GetStr3()
            {
                return "Str3";
            }
        }

        public class T2 : T
        {
            public override string GetStr1()
            {
                return "Str1";
            }

            public override string GetStr3()
            {
                return "Str3";
            }
        }



        public void Use()
        {
            T t1 = new T1();
            t1.Run();
            T t2 = new T2();
            t2.Run();
        }
    }
}
