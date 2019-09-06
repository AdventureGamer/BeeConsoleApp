using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeHive beeHive = new BeeHive();
            Console.WriteLine("Press any key to initialise bee program.");
            Console.ReadLine();
            beeHive.CreateBees();
            Console.WriteLine("Bee hive created");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to damage bees.");
                Console.ReadLine();
                beeHive.DoDamage();

            }
        }
    }
}
