using System;

namespace RuleOfThree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer:");
            int num = int.Parse(Console.ReadLine());
            int i = 0;

            while (num!=1)
            {
                if (num%2==0)
                {
                    num=num/2;
                }
                else 
                {
                    num = num * 3 + 1;
                }i++;
            }
            Console.WriteLine(i+ num);
        }
    }
}
