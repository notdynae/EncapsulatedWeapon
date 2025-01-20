using System;

class Program
{
	static void Main(string[] args) {
		
		Enemy skeleton = new Skeleton("Skeleton", 150, 15);
		Enemy ghost = new Ghost("Ghost", 200, 20);
		Enemy boss = new Boss("Lich", 500, 50);
		
		skeleton.TakeDamage(5);
		skeleton.Attack();
		
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.TakeDamage(5);
		ghost.Attack();
		
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		boss.Attack();
		
		Console.ReadKey();
	}
}
