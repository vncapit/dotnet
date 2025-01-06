using System.Diagnostics;
using DotnetBasic.Day1;
using DotnetBasic.Day2;
using DotnetBasic.Day3;

namespace DotnetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = 10;
                Console.WriteLine($"{a} add one = {a.AddOne()}");
                Console.WriteLine($"{a} minos one = {a.MinosOne()}");

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
