using System.Diagnostics;

namespace Pokemon
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			Pokemon squirtle = new Pokemon("Squirtle", "Water");
			FirePokemon charmander = new FirePokemon("Charmander");

			squirtle.EngageBattle(charmander);
			squirtle.GetAttack();
			charmander.GetAttack();

		}
	}
}