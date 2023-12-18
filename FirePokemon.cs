using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	internal class FirePokemon : Pokemon
	{ 
		public FirePokemon(string name) : base(name, "Fire")
		{
		}

		override public void SpecialAttack()
		{
            Console.WriteLine($"{name} blasts a fireball towards {fighting.name}");
			fighting.TakeDamage(attack * 2);
        }
		
	}
}
