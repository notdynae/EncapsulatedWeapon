using System;

namespace EncapsulatedWeapon
{
	internal class Enemy {
	
		// random instance used for enemy methods
		protected readonly Random Random = new Random();
	
		// ---------------------------------------------- properties
		// auto-implemented name property
		public string Name {get; protected set;}
	
		// validated property, ensuring health remains positive
		private int _health;
		public int Health {
			get => _health;
			protected set => _health = value < 0 ? 0 : value;
		}
		// validated property, ensuring damage remains positive
		private int _damage;
		public int Damage {
			get => _damage;
			protected set => _damage = value < 0 ? 0 : value;
		}
		// computed property to check if enemy is still alive
		public bool IsDead => Health <= 0;
	
		// ----------------------------------------------- methods
		// used for attacking the player
		public virtual void Attack() {
			Console.WriteLine($"{Name} attacked, dealing {Damage} damage");
		}
		// called when player attacked enemy
		public virtual void TakeDamage(int damage)
		{
			Console.WriteLine($"Enemy took {damage} damage!");
			Health -= damage;
			if (IsDead) Die();
		}
		// method to call when enemy runs out of health
		public virtual void Die() {
			Console.WriteLine("Enemy has died!");
		}
	
		// ----------------------------------------------- constructor
		// takes name, total health, and enemy damage output for constructor
		public Enemy(string name, int health, int damage)
		{
			Name = name;
			Health = health;
			Damage = damage;
		}
	}

// Skeleton class, basic unchanged inheritance of Enemy class
	internal class Skeleton : Enemy {
		public Skeleton(string name, int health, int damage) : base(name, health, damage) {}
	}

// Ghost class, overrides TakeDamage method to add possibility to miss
	internal class Ghost : Enemy
	{	
		public Ghost(string name, int health, int damage) : base(name, health, damage) {}

		// 50% chance of missing, and taking no damage
		public override void TakeDamage(int damage) {
			if (Random.Next(0, 2) == 1) Console.WriteLine("Attack missed!");
			else base.TakeDamage(damage);
		}
	}

// Boss class, overrides Attack method to add random variation
	internal class Boss : Enemy
	{
		public Boss(string name, int health, int damage) : base(name, health, damage) {}

		// randomly selected among 3 different attacks
		public override void Attack()
		{
			switch (Random.Next(0, 3))
			{
				case 0: 
					Console.WriteLine($"{Name} wound up and attacked, dealing {Damage} damage!");
					break;
				case 1: 
					Console.WriteLine($"{Name} shook the ground, dealing {Damage + 30} damage!");
					break;
				case 2: 
					Console.WriteLine($"{Name} blasted a fireball, dealing {Damage + 50} damage!");
					break;
			}
		}
	
	}
}