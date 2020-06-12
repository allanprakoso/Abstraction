using System;

namespace Abstraction.AbstractClass
{
    public class Sniper : Heroes
    {
        private String name = "Sniper";
        private Int16 HP = 506, MP = 255, Damage = 36;
        private Double Armor = 3.2;

        public override void profiles()
        {
            Console.WriteLine("Name  : " + name);
            Console.WriteLine("Health: " + HP);
            Console.WriteLine("Mana  : " + MP);
            Console.WriteLine("Damage: " + Damage);
            Console.WriteLine("Armor : " + Armor);
        }

        public override void skill1()
        {
            Console.WriteLine("Shrapnel");
            Console.Write("Sniper melemparkan pecahan-pecahan peluru, area yang diciptakan lumayan besar, ");
            Console.WriteLine("dan akan memberikan DPS dan Slow, Sniper bisa menyimpan charge Shrapnel sebanyak 3.");
        }

        public override void skill2()
        {
            Console.WriteLine("Headshot");
            Console.Write("Skill Passive milik Sniper, serangan sniper bisa memberikan slow ");
            Console.WriteLine("yang sangat parah kepada lawan-lawannya.");
        }

        public override void skill3()
        {
            Console.WriteLine("Take Aim");
            Console.WriteLine("Skill Passive,Menambah Attack Range dari Sniper.");
        }

        public override void ultimate()
        {
            Console.WriteLine("Assassinate");
            Console.Write("Sniper akan mengkeker lawannya, setelah delay beberapa detik, ");
            Console.WriteLine("dia akan menembakkan missile yang sangat sakit.");
        }
    }
}