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
                UserInput userInput = new UserInput();
                SubcriberClass1 sub1 = new SubcriberClass1();
                SubcriberClass2 sub2 = new SubcriberClass2();
                userInput.doMath += sub1.PrintAddOne;
                userInput.doMath += sub2.PrintMinosOne;

                userInput.onUserInputed += sub1.PrintAddOneHandler;
                userInput.onUserInputed += sub2.PrintMinosOneHandler;
                userInput.Run();

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
