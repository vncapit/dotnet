using System.Diagnostics;
using DotnetBasic.Day1;
using DotnetBasic.Day2;

namespace DotnetBasic
{
    internal class Program
    {
        delegate void Print(string text);
        static void PrintInfo(string text)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine(text);
            Console.ResetColor();
        }
        static void PrintWarning(string text)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static void WriteLog(string text, Print print)
        {
            print(text);
        }

        static Action<string> printAction;

        static Func<int, int, int> mathFucn;

        static int findMax(int a, int b) => a > b ? a : b;

        static void Main(string[] args)
        {
            try
            {
                Print print = null;
                print += PrintInfo;
                //print("Abc");
                print += PrintWarning;
                //print("xyz");
                print.Invoke("ZZZ");

                WriteLog("wwwwwwwwwww", PrintWarning);

                printAction?.Invoke("ddd");
                printAction += PrintInfo;
                printAction.Invoke("Print info");

                mathFucn += findMax;
                int a = 3;
                int b = 5;
                Console.WriteLine($"Max of {a} and {b} is {mathFucn.Invoke(a, b)}");


                //Weapon ak47 = new Weapon("AK47", WeaponType.Rifle);
                //ak47.Weight = 5200;
                //ak47.Damage = 100;
                //Console.WriteLine(ak47.ToString());

                //Shape circle = new Circle(10);
                //circle.Info();

                //(circle as Circle).CircleSpecialMethod();

                
                //Circle newCircle = new Circle(10);
                //newCircle.CircleSpecialMethod();

                //IShape rectangle = new Rectangle(10, 5);
                //rectangle.Info();


            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
