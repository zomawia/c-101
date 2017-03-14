using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Describes a type that can take damage.
    interface IDamageable
    {
        // Estimates the amount of health lost if damage is dealt. 
        float EstimatedDamageTaken(float damageDealt);

        // Applies damage to this object.
        void TakeDamage(float damageDealt);
    }
    class PlayerHealth : IDamageable
    {
        public float healthValue;
        public float armorValue;

        public PlayerHealth() : this(100,0){}

        public PlayerHealth(float startHealth) : this(startHealth, 0){}

        public PlayerHealth(float startHealth, float startArmor)
        {
            healthValue = startHealth;
            armorValue = startArmor;
        }

        float IDamageable.EstimatedDamageTaken(float damageDealt)
        {
            if (armorValue <= 0) return damageDealt;
            return (damageDealt / armorValue);
        }

        void IDamageable.TakeDamage(float damageDealt)
        {
            IDamageable dmg = this;
            healthValue -= dmg.EstimatedDamageTaken(damageDealt);
        }
    }

    /////////////////////////////////////////////////////////////////////

    class PlayerHealthAscending : Comparer<PlayerHealth>
    {
        public override int Compare(PlayerHealth lhs, PlayerHealth rhs)
        {
            int x = (int)lhs.healthValue;
            int y = (int)rhs.healthValue;
            if (x > y) return 1;
            if (x < y) return -1;
            else return 0;            
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PlayerHealth myPlayer = new PlayerHealth(100, 0);
            Console.WriteLine(myPlayer.healthValue);
            IDamageable target = myPlayer;
            target.TakeDamage(50);

            Console.WriteLine(myPlayer.healthValue);
            Console.WriteLine(' ');

            /////////////////////////////////////////////////////////////

            List<PlayerHealth> healths = new List<PlayerHealth>();

            healths.Add(new PlayerHealth(12));
            healths.Add(new PlayerHealth(19));
            healths.Add(new PlayerHealth(5));
            healths.Add(new PlayerHealth(30));

            healths.Sort(new PlayerHealthAscending());

            foreach (PlayerHealth health in healths)
            {
                Console.WriteLine(health.healthValue);
            }

            Console.ReadLine();
        }
    }
}
