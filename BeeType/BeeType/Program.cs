using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeType
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Bee> list = new List<Bee>(0);
            CreateNewBees(list);
            bool exit = false;

            while (!exit)
            {
                Console.Write("Input: ");

                string resp = Console.ReadLine();
                switch (resp)
                {
                    case "1":
                        CreateNewBees(list);
                        for (int i = 0; i < list.Count; i++)
                        {
                            PrintBee(i + 1, list[i]);
                        }
                        break;
                    case "2":
                        var random = new Random();
                        for (int i = 0; i < list.Count; i++)
                        {
                            var damage = random.Next(0, 80);
                            list[i].Damage(damage);
                            PrintBee(i + 1, list[i]);
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        private static void PrintBee(int number, Bee bee)
        {
            Console.WriteLine("{0}: {1}\talive = {2}\thealth = {3}", number, bee.Type, bee.Alive, bee.Health);
        }

        private static void CreateNewBees(List<Bee> list)
        {
            list.Clear();
            for (int i = 0; i < 10; i++)
            {
                list.Add(new Worker());
                list.Add(new Drone());
                list.Add(new Queen());
            }
        }
    }
}

