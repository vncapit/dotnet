using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetBasic.Day1
{
    public enum WeaponType
    {
        Handgun,
        Shotgun,
        Rifle
    }
    internal class Weapon(string name, WeaponType weaponType)
    {
        public string Name { get; } = name;
        WeaponType weaponType;
        public WeaponType WeaponType { get; } = weaponType;
        int damage;
        public int Damage {
            get { return this.damage; }
            set
            {
                if (this.damage <= 0) throw new Exception("Bad damage");
                this.damage = value;
            }
        }

        public int Weight {  get; set; }

        public override string ToString() {
            return $"This is a {WeaponType}";
        }
    }
}
