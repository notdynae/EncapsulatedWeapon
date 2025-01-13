using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class Enemy {

	public string Name {get; private set;}
	
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
	
	public virtual void Attack() {
		Console.WriteLine($"{Name} attacked, dealing {Damage} damage");
	}
	public virtual void TakeDamage(int damage) {
		Health -= damage;
		if (IsDead) Die();
	}
	public virtual void Die() {
		Console.WriteLine("Enemy has died!");
	}
	
	public Enemy(string name, int health, int damage) {
		Name = name;
		Health = health;
		Damage = damage;
	}
}

internal class Skeleton : Enemy
{
	public Skeleton(string name, int health, int damage) : base(name, health, damage)
	{
	}
}
