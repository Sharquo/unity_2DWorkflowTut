using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour {

	public float speed = 0.3f;
	private Rigidbody2D velo;
	
	private void Awake()
	{
		velo = GetComponent<Rigidbody2D>();
	}
	void Update () {
		velo.velocity = new Vector2 (this.transform.localScale.x, 0) * speed;		
	}
}
