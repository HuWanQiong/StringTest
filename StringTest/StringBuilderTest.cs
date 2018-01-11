using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTest
{
    /// <summary>
    /// 面试:需要大量拼接字符串需要怎么优化?
    /// 回答:StringBuilder.
    /// </summary>
    class StringBuilderTest
    {
        static void Main1(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            DateTime dt2 = DateTime.Now;
            for (int i = 0; i < 200000; i++)
            {
                sb.Append("aaaaa");
            }
            string str2 = sb.ToString();
            Console.WriteLine((DateTime.Now - dt2).TotalMilliseconds);


            DateTime dt = DateTime.Now;
            string str = "";
            for (int i = 0; i < 200000; i++)
            {
                str += "bbbbbbb";
            }
            Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);

            Console.ReadLine();
        }
    }
}
