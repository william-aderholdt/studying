using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "azabbbccc";
            Char[] lStrArr = s.ToCharArray();

            int lErrorCnt = 0;

            for (int i = 0; i < lStrArr.Length; i++)
            {
                if (lStrArr[i] == 'a' || lStrArr[i] == 'b' || lStrArr[i] == 'c' || lStrArr[i] == 'd' || lStrArr[i] == 'e' ||
                    lStrArr[i] == 'f' || lStrArr[i] == 'g' || lStrArr[i] == 'h' || lStrArr[i] == 'i' || lStrArr[i] == 'j' ||
                    lStrArr[i] == 'k' || lStrArr[i] == 'l' || lStrArr[i] == 'm')
                {
                }

                else
                {
                    lErrorCnt++;
                }
                    
                    Console.WriteLine(lErrorCnt);
                    Console.ReadLine();

            }

            string answer = lErrorCnt + "/" + lStrArr.Length;

            Console.WriteLine(answer);
            Console.ReadLine();
        }
    }
}
