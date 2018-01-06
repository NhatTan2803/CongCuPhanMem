using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        public static void PrintBee(int number, Bee bee)
        {
            Console.WriteLine("{0}: {1}\talive = {2}\thealth = {3}\tdenfense ={4}", number, bee.Name, bee.Alive, bee.Health, bee.defense);

        }
        private static void PrintHive(Hive hive)
        {
            Console.WriteLine("Hive \t Durability: {0} \t Honey: {1} \n", hive.durability, hive.Honey);

        }
        public static void PrintFlower(Flower lw)
        {
            Console.WriteLine("Fower Name: {0}:\t \tDeath: {1} \t Pollen ={2} \t Poison: {3}", lw.FlowerName, lw.Death, lw.pollen, lw.poison);
        }
        private static void CreateNewBees(List<Bee> list, int num)
        {
            list.Clear();
            Random rd; int numBee;
            for(int i =0; i<num; i++)
            {
                rd = new Random();
                numBee = rd.Next(1, 4);
                switch(numBee)
                {
                    case 1: list.Add(new Worker()); break;
                    case 2: list.Add(new Drone()); break;
                    case 3: list.Add(new Queen()); break;
                }
            }
        }
        private static void CreateHive(List<Hive> list, int NBee)
        {
            list.Clear();
            Hive hive = new Hive();
            hive.NumBee = NBee;
            hive.Honey = 0;
            hive.durability = 100;
            hive.Pollen = 0;
            list.Add(hive);
        }
        public static void CreateFlower(List<Flower> list, int Ftype, int NumF)
        {
            list.Clear();
            Flower lw;
            Random rd;
            int nname = 0; int n;
            for (int i = 0; i < Ftype; i++)
            {
                for (int j = 0; j < NumF; j++)
                {
                    lw = new Flower(); rd = new Random(); n = rd.Next(0, 2);
                    lw.FlowerName = "Flower" + nname.ToString();
                    lw.LowerType = 1;
                    if (n == 0)
                    {
                        lw.poison = false;
                    }
                    else
                    {
                        lw.poison = true;
                    }
                    lw.pollen = 50;
                    list.Add(lw);
                    nname++;
            

                 }
            }
        }
        public static void BuilHive(Hive hive, int rnd, Bee bee)
        {
            if (hive.durability > 100)
                hive.durability = 0;
            else
                if (bee.Health == 0)
            {
                hive.durability += 0;
                hive.Honey += 0;
            }
            else
            {
                hive.durability += Convert.ToInt32((10 - Convert.ToInt32(10 * (rnd * 0.01))) * 0.5);
                if (hive.durability > 100)
                {
                    hive.durability = 100;
                }
                hive.Honey = (hive.Pollen - (Convert.ToInt32(hive.Pollen * (rnd * 0.1)))) - Convert.ToInt32((hive.Pollen - (Convert.ToInt32(hive.Pollen * (rnd * 0.1)))) * 0.5);
            }
        }

    private static void GenPoisen(Hive hive, Bee bee, Flower flower)
        {
            if (bee.Health == 0)
            {
                hive.Pollen += 0;
                flower.pollen -= 0;
            }
            else
        if (flower.pollen == 0)
            {
                hive.Pollen += 0;
            }
            else
            if (flower.poison == true)
            {
                bee.Health = 0;
                hive.Pollen += 0;
                flower.pollen -= 0;
            }
            else
            {
                flower.pollen -= 10;
                hive.Pollen += 10;
            }
        }
        private static void AttactHive(Hive hibe, int dame)
        {
            hibe.durability -= Math.Abs(Convert.ToInt32(0.05 * dame));
        }
        public static void Main(String[] args)
        {
            List<Bee> list = new List<Bee>();
            List<Hive> lhive = new List<Hive>();
            List<Flower> lflower = new List<Flower>();
            bool exit = false;
            while (!exit)
            {
                Console.Write("\n1. Create new list Bee\n" +
                        "2. Attact Bees\n" +
                        "3. A worker and drone attact other Bees\n" +
                        "4. Bee defense\n" +
                        "5.Create Flower have 10 type and 100 flower\n" +
                        "6.Create Hive 'Have 10 bees' \n" +
                        "7. Get Pollen\n" +
                        " Press number keys 0 to Exit!\n"
                        );
                Console.Write("Choose: ");
                int choose = Int32.Parse(Console.ReadLine());
                switch (choose)
                {
                    case 1:
                        CreateNewBees(list, 10);
                        for (int i = 0; i < list.Count; i++)
                        {
                            PrintBee(i + 1, list[i]);
                        }
                        CreateHive(lhive, 10);
                        break;
                    case 2:
                        var random = new Random();
                        for (int i = 0; i < list.Count; i++)
                        {
                            var damage = random.Next(0, 80);
                            list[i].Damage(damage);
                            PrintBee(i + 1, list[i]);
                            AttactHive(lhive[0], damage);
                        }
                        break;
                  case 3: 
                        var rd = new Random(); int dame;
                        for (int i = 0; i < list.Count; i++)
                        {
                            rd = new Random();
                            if (list[i].Type == 1)
                            {
                                dame = rd.Next(0, 30);
                                list[i].WorkDroreDamage(dame);
                                PrintBee(i + 1, list[i]);

                                AttactHive(lhive[0], dame);
                            }
                            if (list[i].Type == 2)
                            {
                                dame = rd.Next(0, 40);
                                list[i].WorkDroreDamage(dame);
                                PrintBee(i + 1, list[i]);

                                AttactHive(lhive[0], dame);
                            }
                            if (list[i].Type == 3)
                            {
                                dame = 0;
                                list[i].WorkDroreDamage(dame);
                                PrintBee(i + 1, list[i]);

                                AttactHive(lhive[0], dame);
                            }
                        }
                        break;

                        case 4: var rnd = new Random(); int def;
                                        for (int i = 0; i < list.Count; i++)
                                        {
                                            rnd = new Random();
                                            def = rnd.Next(10, 20);
                                            list[i].Defense(def);
                                        }
                                        break;

                }
            }
         }
     }
}
