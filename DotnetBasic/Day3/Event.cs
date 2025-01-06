using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasic.Day3
{
    internal class UserInput
    {

        public delegate void DoMath(int input);

        public DoMath? doMath;

        public event EventHandler onUserInputed;
        
        public void Run()
        {
            do
            {
                Console.WriteLine("Please input a number: ");
                var inputString = Console.ReadLine();
                if (string.IsNullOrEmpty(inputString)) continue;
                var inputNumber = Int32.Parse(inputString);
                doMath?.Invoke(inputNumber);
                onUserInputed?.Invoke(this, new UserInputEventArgs(inputNumber));
            }
            while (true);

        }
    }

    class SubcriberClass1
    {
        public void PrintAddOne(int value)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{value} + 1 = {value + 1}");
            Console.ResetColor();
        }

        public void PrintAddOneHandler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int value = (e as UserInputEventArgs).Input;
            Console.WriteLine($"From event handler: {value} + 1 = {value + 1}");
            Console.ResetColor();
        }
    }

    class SubcriberClass2
    {
        public void PrintMinosOne(int value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{value} - 1 = {value - 1}");
            Console.ResetColor();
        }

        public void PrintMinosOneHandler(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            int value = (e as UserInputEventArgs).Input;
            Console.WriteLine($"From event handler: {value} - 1 = {value - 1}");
            Console.ResetColor();
        }
    }

    class UserInputEventArgs : EventArgs {
        public int Input {  get; set; }
        public UserInputEventArgs(int input) { 
            this.Input = input;
        }
    }


}
