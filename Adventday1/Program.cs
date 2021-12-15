using System;
using System.IO;

namespace Adventday1
{
    class Advent1
    {
        static void Main(string[] args)
        {

            int count = 0;
            string[] sonarlist = File.ReadAllLines("C:/Users/Alexander/source/repos/Adventday1/sonarlist.txt");
            int[] numberlist = new int[sonarlist.Length];
            for (int i = 0; i < sonarlist.Length; i++)                
            {
                numberlist[i] = int.Parse(sonarlist[i]);
            }

            for (int j = 1; j < numberlist.Length; j++)
            {
                if (numberlist[j] > numberlist[j - 1])
                {
                    count++;
                }                           
            }
            Console.WriteLine(SlidingSum(numberlist));
        }

        static int SlidingSum(int[] numberlist)
        {
            int sum = 0;
            for (int j = 0; j < (numberlist.Length - 3); j++)
            {
                if (numberlist[j] + numberlist[j + 1] + numberlist[j + 2] < numberlist[j + 1] + numberlist[j + 2] + numberlist[j + 3])
                {
                    sum++;
                }
                
                
            }
            return sum;
        }


    }
}
