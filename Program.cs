using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nNum = 0;

            while (true)
            {
                Console.WriteLine("nNum : {0}", nNum++);

                if (nNum >= 5)
                    break;
            }
        }
    }
}
