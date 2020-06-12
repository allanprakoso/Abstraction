using System;
namespace Abstraction.Interface
{
    public class Bloodseeker : IHeroes
    {
       private String name = "Bloodseeker";
        private Int16 HP = 200, MP = 75, Damage = 33;
        private Double Armor = 4.8;

        public void profiles()
        {
            Console.WriteLine("Name  : " + name);
            Console.WriteLine("Health: " + HP);
            Console.WriteLine("Mana  : " + MP);
            Console.WriteLine("Damage: " + Damage);
            Console.WriteLine("Armor : " + Armor);
        }

        public void skill1()
        {
            Console.WriteLine("Bloodrage");
            Console.Write("Skill Buff, jika membunuh musuh ketika dalam effect skill ini ");
            Console.WriteLine("maka HP-mu akan bertambah berdasarkan Max HP musuh yang kamu bunuh.");
        }

        public void skill2()
        {
            Console.WriteLine("Blood Rite");
            Console.Write("Bloodseeker menciptakan sebuah area ritual, setelah ");
            Console.WriteLine("beberapa waktu, area ini akan memberikan Damage dan Silence.");
        }

        public void skill3()
        {
            Console.WriteLine("Thirst");
            Console.Write("Skill Passive milik bloodseeker, menambah damage");
            Console.WriteLine(" dan MS bloodseeker, akan active jika HP musuhmu dibawah 75%");
        }

        public void ultimate()
        {
            Console.WriteLine("Rupture");
            Console.Write("Bloodseeker menciptakan sebuah area ritual, setelah ");
            Console.WriteLine("beberapa waktu, area ini akan memberikan Damage dan Silence.");
        } 
    }
}