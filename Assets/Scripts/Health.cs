using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int maxHealth = 10;
	public int health = 10;
	void Start () {
		health = maxHealth;
	}
	
	void Update () {
		
	}

	public void takeDamage(int value) {
		health -= value;

		if (health <= 0)
		{
			OnKill();
		}
	}

	void OnKill() {
		Destroy(gameObject);
	}
}
