using System;

internal class Enemy {
	
	protected Random random = new Random();
	
	// ---------------------------------------------- properties
	public string Name {get; protected set;}
	
	private int _health;
	public int Health {
		get => _health;
		protected set => _health = value < 0 ? 0 : value;
	}
	private int _damage;
	public int Damage {
		get => _damage;
		protected set => _damage = value < 0 ? 0 : value;
	}
	public bool IsDead => Health <= 0;
	
	// ----------------------------------------------- methods
	public virtual void Attack() {
		Console.WriteLine($"{Name} attacked, dealing {Damage} damage");
	}
	public virtual void TakeDamage(int damage)
	{
		Console.WriteLine($"Enemy took {damage} damage!");
		Health -= damage;
		if (IsDead) Die();
	}
	public virtual void Die() {
		Console.WriteLine("Enemy has died!");
	}
	
	// ----------------------------------------------- constructor
	public Enemy(string name, int health, int damage)
	{
		Name = name;
		Health = health;
		Damage = damage;
	}
}

internal class Skeleton : Enemy {
	public Skeleton(string name, int health, int damage) : base(name, health, damage) {}
}

internal class Ghost : Enemy
{	
	public Ghost(string name, int health, int damage) : base(name, health, damage) {}

	public override void TakeDamage(int damage) {
		if (random.Next(0, 2) == 1) Console.WriteLine("Attack missed!");
		else base.TakeDamage(damage);
	}
}

internal class Boss : Enemy
{
	public Boss(string name, int health, int damage) : base(name, health, damage) {}

	public override void Attack()
	{
		switch (random.Next(0, 3))
		{
			case 0: 
				Console.WriteLine($"{Name} wound up and attacked, dealing {Damage} damage!");
				break;
			case 1: 
				Console.WriteLine($"{Name} shook the ground, dealing {Damage} damage!");
				break;
			case 2: 
				Console.WriteLine($"{Name} blasted a fireball, dealing {Damage} damage!");
				break;
		}
	}
	
}
