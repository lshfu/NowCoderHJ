using System;

namespace HJ15
{
    class Program
    {
        /// <summary>
        /// 求int型正整数在内存中存储时1的个数
        /// 输入一个int型的正整数，计算出该int型数据在内存中存储时1的个数
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i;
            bool b;
            do
            {
                b = Int32.TryParse(Console.ReadLine(), out i);
            }
            while (!b || i < 0);

            var t = Convert.ToString(i, 2);
            var result = t.Replace("0", "").Length;

            Console.WriteLine(result);
        }
    }
}
