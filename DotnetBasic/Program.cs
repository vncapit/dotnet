using DotnetBasic.Day1;
using DotnetBasic.Day2;

namespace DotnetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Weapon ak47 = new Weapon("AK47", WeaponType.Rifle);
                //ak47.Weight = 5200;
                //ak47.Damage = 100;
                //Console.WriteLine(ak47.ToString());

                Shape circle = new Circle(10);
                circle.Info();

                (circle as Circle).CircleSpecialMethod();

                
                Circle newCircle = new Circle(10);
                newCircle.CircleSpecialMethod();

                IShape rectangle = new Rectangle(10, 5);
                rectangle.Info();

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
