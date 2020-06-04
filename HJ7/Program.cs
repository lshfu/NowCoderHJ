using System;

namespace HJ7
{
    class Program
    {
        /// <summary>
        /// 取近似值
        /// 接受一个正浮点数值，输出该数值的近似整数值。如果小数点后数值大于等于5,向上取整；小于5，则向下取整。
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double d;
            bool b;
            do
            {
                b = Double.TryParse(Console.ReadLine(), out d);
            }
            while (!b || d < 0);

            int result = (int)d;
            if (d - result >= 0.5)
                result += 1;

            Console.WriteLine(result);
        }
    }
}
