using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

internal class Enemy {

	Random r = new Random();

	public string Name {get; private set;}
	private int health;
	public int Health {
		get { return health; }
		private set {
			if (value < 0) health = 0;
			else health = value;
			return;
		}
	}

	public Enemy(string enemyName, int enemyHealth) {
		Name = enemyName;
		Health = enemyHealth;
	}

	public void TakeDamage(int damage) {
		Health -= damage;
	}
}
