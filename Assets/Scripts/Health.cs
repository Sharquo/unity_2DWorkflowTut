using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

	public int maxHealth = 10;
	public int health = 10;
	public GameObject deathInstance = null;
	public Vector2 deathInstanceOffset = new Vector2(0,0);
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
		if (deathInstance)
		{
			var pos = gameObject.transform.position;
			GameObject clone = Instantiate (deathInstance, new 
			Vector3(pos.x + deathInstanceOffset.x, pos.y + deathInstanceOffset.y, 
			pos.z), Quaternion.identity) as GameObject;
		}
		Destroy(gameObject);
	}
}
