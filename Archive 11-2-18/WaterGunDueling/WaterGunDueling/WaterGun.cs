using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaterGunDueling
{
    class WaterGun
    {
        Random rand = new Random();
        public float Capacity { get; private set; }
        public bool IsWet { get; set; }

        public WaterGun()
        {
            Capacity = 1;
        }

        /// <summary>
        /// Fires the water gun at the target.
        /// </summary>
        /// <param name="amount">The amount to shoot</param>
        /// <returns>True if we hit our target, false otherwise</returns>
        public bool Shoot(float amount)
        {
            //If we don't have ammo, we can't shoot
            if (Capacity > 0)
            {
                //Deduct the amount to shoot
                Capacity -= amount;

                //Did we have a full shots worth? Or did we just fire what was left
                if (Capacity < 0)
                {
                    amount += Capacity;
                    Capacity = 0;
                }

                //Roll the dice to see if we hit the target
                float val = (float)rand.NextDouble();
                if (val < (amount * .2f) + .2f)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                Console.WriteLine("You tried to fire an empty weapon... Refill!");
                return false;
            }

        }

        /// <summary>
        /// Refills the watergun. Refill only fills 1/4th of a tank
        /// </summary>
        public void Refill()
        {
            Capacity += .25f;
            if (Capacity >= 1)
            {
                Capacity = 1;
            }
        }
    }
}
