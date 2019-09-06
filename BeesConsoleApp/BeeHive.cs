using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    public class BeeHive
    {
        private Drone droneBee;
        private Worker workerBee;
        private Queen queenBee;
        public List<Bee> BeeFamily { get; set; } = new List<Bee>();

        Random random = new Random();

        public void CreateBees()
        {
            string beeName = "";
            for (int i = 0; i < 10; i++)
            {
                beeName = "Drone" + i;
                droneBee = new Drone(beeName);
                BeeFamily.Add(droneBee);
                beeName = "Worker" + i;
                workerBee = new Worker(beeName);
                BeeFamily.Add(workerBee);
                beeName = "Queen" + i;
                queenBee = new Queen(beeName);
                BeeFamily.Add(queenBee);


            }
        }
        public void DoDamage()
        {
            int damage = 0;
            foreach (Bee beeType in BeeFamily)
            {
                if (beeType.isDead)
                {
                    Console.WriteLine(beeType.beeObjectName + " is dead and takes no damage.");
                }
                else
                {
                    damage = random.Next(80);
                    beeType.TakeDamage(damage);
                    Console.WriteLine(beeType.beeObjectName + " took " + damage + " damage.");
                    if (!beeType.CanStillFly())
                    {
                        Console.WriteLine(beeType.beeObjectName + " can no longer fly at " + beeType.Health + " health" +
                            ", and died.");
                    }
                    else
                    {
                        Console.WriteLine(beeType.beeObjectName + " is still able to fly at " + beeType.Health + " health.");
                    }
                }


            }
        }
    }




}
