using DotnetBasic.Day1;

namespace DotnetBasic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Weapon ak47 = new Weapon("AK47", WeaponType.Rifle);
                ak47.Weight = 5200;
                ak47.Damage = 100;
                Console.WriteLine(ak47.ToString());

            }
            catch (Exception ex) { 
                Console.WriteLine(ex.ToString());
            }

            Console.ReadLine();
        }
    }
}
