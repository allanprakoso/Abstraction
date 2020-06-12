using System;

namespace Abstraction.AbstractClass
//namespace Abstraction.Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroes;
        //IHeroes heroes;
        pilihhero:
            Console.WriteLine("++ Dota 2 Heroes Information++");
            Console.WriteLine("1. Bloodseeker");
            Console.WriteLine("2. Sniper");
            Console.Write("Pilihan: ");
            int pilihanhero = Convert.ToInt32(Console.ReadLine());

            if (pilihanhero == 1)
                heroes = new Bloodseeker();
            else
                heroes = new Sniper();

            while (true)
            {
                Console.WriteLine("++ Menu ++");
                Console.WriteLine("1. Profiles Hero");
                Console.WriteLine("2. Skill 1");
                Console.WriteLine("3. Skill 2");
                Console.WriteLine("4. Skill 3");
                Console.WriteLine("5. Ultimate");
                Console.WriteLine("6. Kembali");

                Console.Write("\nPilihan: ");
                int pilihan = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (pilihan)
                {
                    case 1:
                        heroes.profiles();
                        break;
                    case 2:
                        heroes.skill1();
                        break;
                    case 3:
                        heroes.skill2();
                        break;
                    case 4:
                        heroes.skill3();
                        break;
                    case 5:
                        heroes.ultimate();
                        break;
                }
                Console.WriteLine();
                if (pilihan == 6)
                {
                    Console.Clear();
                    goto pilihhero;
                }
            }
        }
    }
}
