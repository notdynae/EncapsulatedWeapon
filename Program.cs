using System;

namespace EncapsulatedWeapon
{
	internal static class Program
	{
		static void Main(string[] args) {
		
			// creating instances of all enemies
			Enemy skeleton = new Skeleton("Skeleton", 150, 15);
			Enemy ghost = new Ghost("Ghost", 200, 20);
			Enemy boss = new Boss("Lich", 500, 50);
		
			// basic skeleton tests, all 
			skeleton.TakeDamage(5);
			skeleton.Attack();
			Console.WriteLine();
		
			// repeats ghost taking damage, to see variation in results
			for (var i=0; i<10; i++) { ghost.TakeDamage(5); }
			ghost.Attack();
			Console.WriteLine();
		
			// repeats boss attack, to see variation in results
			for (var i=0; i<10; i++) { boss.Attack(); }
			boss.TakeDamage(10);
		
			Console.ReadKey();
		}
	}
}
