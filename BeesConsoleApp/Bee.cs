using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeesConsoleApp
{
    public abstract class Bee
    {
        public string beeObjectName;
        public float Health = 100f;

        public bool isDead = false;

        protected float FlyingEndurance;

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public bool CanStillFly()
        {
            if (Health < FlyingEndurance)
            {
                isDead = true;
                return false;
            }
            return true;
        }
    }
}