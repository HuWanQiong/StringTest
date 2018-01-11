using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    /// <summary>
    /// 面试:string是引用类型还是值类型?
    /// 回答:引用类型.
    /// 面试：string为引用类型?那如下,调用SetStr方法为何输出结果为何不为"bbb"?
    /// 回答：string是一个特殊的引用类型.
    /// 面试:需要大量拼接字符串需要怎么优化?
    /// 回答:StringBuilder.
    /// </summary>
    class Program
    {
        public void SetStr(string str)
        {
            str = "bbb";
        }

        static void Main(string[] args)
        {
            string str = "aaa";
            Program p = new Program();
            p.SetStr(str);
            Console.WriteLine(str); //输出结果:aaa

            /*string是一个特殊的引用类型,用法跟值类型相似;string是只读的引用类型，修改string对象会创建新的实例*/

            str = "ccc";
            Test t = new Test();
            t.mystr = str;
            Console.WriteLine(str); //输出结果:ccc

            Console.ReadLine();
        }
    }
}
