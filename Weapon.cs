using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using EncapsulatedWeapon;

internal class Weapon {

	Random r = new Random();

	private string name;
	private int damage;
	private int durability;

	// ---------------------------------------------------- Weapon constructor
	public Weapon(string weaponName, int weaponDamage, int weaponDurability) {
		name = weaponName;
		damage = weaponDamage;
		durability = weaponDurability;
	}

	// Deal weapon damage to passed in enemy, prints status and applies durability to weapon, potentially breaking it
	public void DealDamage(Enemy enemy) {

		durability = Math.Max(0, durability - r.Next(1, 6));
		Console.WriteLine($"{enemy.Name} was dealt {damage} damage with {name}.\n{enemy.Name}'s health is {enemy.Health}.\n{name}'s durability is {durability}.");
		enemy.TakeDamage(damage);

		if (durability <= 0) {
			damage = 0;
			Console.WriteLine($"{name} is broken.");
		}
	}
}
