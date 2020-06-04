using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HJ14
{
    class Program
    {
        /// <summary>
        /// 字串的连接最长路径查找
        /// 给定n个字符串，请对n个字符串按照字典序排列
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            bool b;
            int n;
            do
            {
                //Console.WriteLine("请输入一个正整数n(1<=n<=1000):");
                b = Int32.TryParse(Console.ReadLine(), out n);
            } while (!b || n < 1 || n > 1000);

            string[] sa = new string[n];
            for (int i = 0; i < n; i++)
            {
                string sinput;
                do
                {
                    //Console.WriteLine($"请输入第 {i + 1} 个只包含大小写字母的字符串：");
                    sinput = Console.ReadLine();
                } while (!Regex.IsMatch(sinput, "[a-zA-Z]"));
                sa[i] = sinput;
            }
            Array.Sort(sa, string.CompareOrdinal);

            foreach (var item in sa)
            {
                Console.WriteLine(item);
            }
        }
    }
}
