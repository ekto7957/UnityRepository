using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L250123_Practice
{
    internal class Damage
    {
        int type = 4;
        private float damage = 10;

        public void CalculateDamage()
        {
            if (type == 4)
            {
                damage = damage * (1 + 0.3f); // damage를 30% 증가
            }

            Console.WriteLine($"Damage: {damage}");
        }
    }

}
