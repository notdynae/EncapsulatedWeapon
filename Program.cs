using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args) {

		Weapon stoneSword = new Weapon("Stone Sword", 7, 40);
		Weapon goldAxe = new Weapon("Gold Axe", 15, 25);

		Enemy goblin = new Enemy("Goblin", 150);
		Enemy zombie = new Enemy("Zombie", 500);

		for (int i = 0; i < 15; i++) {
			stoneSword.DealDamage(goblin);
		}
		Console.WriteLine();
		for (int i = 0; i < 15; i++) {
			goldAxe.DealDamage(zombie);
		}

		Console.ReadKey();
	}
}
