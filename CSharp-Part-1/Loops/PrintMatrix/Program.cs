using System;
namespace PrintMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int iterator = i;
                for (int j = 1; j <= n; j++)
                {
                    Console.Write(iterator);
                    if (j != n)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                    iterator++;
                }
            }
        }
    }
}

//using System;
//namespace PrintMatrix
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int lineBreak = n;
//            int number = 1;
//            int iterator = 1;
//            for (int i = 1; i <= n * n; i++)
//            {
//                if (i != lineBreak)
//                {
//                    Console.Write(number);
//                    Console.Write(" ");
//                    number++;
//                }
//                else
//                {
//                    Console.Write(number);
//                    Console.WriteLine();
//                    lineBreak += n;
//                    number = 1 + iterator;
//                    iterator++;
//                }
//            }
//        }
//    }
//}
