using System.ComponentModel;
using System.Diagnostics;
using DotnetBasic.Day1;
using DotnetBasic.Day2;
using DotnetBasic.Day3;
using DotnetBasic.Day4;

namespace DotnetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var practice = new Practice();
                practice.Run();
            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
