using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
	internal class Pokemon
	{
		public string name;
		string type;
		public int attack;
		int defence;
		int health;
		int speed;
		public Pokemon fighting;

		public Pokemon(string name, string type)
		{
			this.name = name;
			this.type = type;
			attack = 5;
			defence = 5;
			health = 50;
			speed = 5;
			fighting = null;
            Console.WriteLine($"Welcome to the world {name}, the {type} type.");
        }

		public void GetAttack()
		{
            Console.WriteLine("Select Attack!");
            Console.WriteLine("1. quick attack");
            Console.WriteLine("2. special attack");
            Console.WriteLine("3. run away");
            Console.Write(">>");
            string option = Console.ReadLine();
			switch (option)
			{
				case "1":
					QuickAttack();
					break;
				case "2":
					SpecialAttack();
					break;
				case "3":
					RunAway();
					break;
				default:
					Console.WriteLine("What's that then?");
					break;
			}
        }

		public void TakeDamage(int damage)
		{
			if (damage > 0)
			{
				Console.WriteLine($"{name} is hurt by the attack");
				health = health - damage;
			}
			if (health <= 0)
			{
				Console.WriteLine($"{name} has fainted!");
				fighting.fighting = null;
				fighting = null;
			}
		}

		public void EngageBattle(Pokemon opponent)
		{
			fighting = opponent;
            Console.WriteLine($"{name} readies to battle {opponent.name}");
			opponent.fighting = this;
        }

		public void QuickAttack()
		{
            Console.WriteLine($"{name} performs quick attack");
			fighting.TakeDamage(attack);
        }

		virtual public void SpecialAttack()
		{
			Console.WriteLine($"{name} performs special attack");
			fighting.TakeDamage(attack * 2);
		}

		public void RunAway()
		{
			Console.WriteLine($"{name} runs away");
			fighting.fighting = null;
			fighting = null;
		}

	}
}
