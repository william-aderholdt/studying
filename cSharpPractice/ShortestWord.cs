using System;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main (string[] arr)
        {
            FindShort();
        }
        public static int FindShort()
        {
            public static int FindShort(string s)
            {
                string[] lArrS = s.Split(' ');
                int lShortestString = lArrS[0].Length;

                for (int i = 0; i < lArrS.Length; i++)
                {
                    if (lArrS[i].Length < lShortestString)
                    {
                        lShortestString = lArrS[i].Length;
                    }
                }

                return lShortestString;
            }
        }
    }
}
