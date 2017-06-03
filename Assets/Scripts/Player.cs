using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float speed = 200;
	public float maxSpeed = 5;
	int moving = 0;
	
	private Rigidbody2D rigi;
	private void Awake ()
	{
		rigi = GetComponent<Rigidbody2D>();
	}

	void Update () {
		if (Input.GetKey("right"))
		{
			moving = 1;
		}
		else if (Input.GetKey("left"))
		{
			moving = -1;
		}
		else
		{
			moving =0;
		}

		if (moving != 0)
		{
			var velocityX = System.Math.Abs(rigi.velocity.x);

			if (velocityX < 0.5)
			{
				rigi.AddForce(new Vector2(moving, 0) * speed);

				if (this.transform.localScale.x != moving)
				this.transform.localScale = new Vector3(moving, 1, 1);
				{
					if (velocityX > maxSpeed)
					rigi.velocity = new Vector2(maxSpeed * moving, 0);
				}
			}
		}
	}
}
