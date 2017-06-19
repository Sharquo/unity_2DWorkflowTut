using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour {
	
	public int attackValue = 1;
	public float attackDelay = 1f;
	public string targetTag;
	private bool canAttack;

	void Start () {
		if (attackValue <= 0)
		canAttack = false;
		else
		StartCoroutine(OnAttack());
	}

	void OnCollisionStay2D(Collision2D c) {
		if (c.gameObject.tag == targetTag)
		{
			if (canAttack)
			TestAttack(c.gameObject);
		}
	}

    void TestAttack(GameObject target)
    {
        if (transform.localScale.x == 1)
		{
			if (target.transform.position.x > transform.position.x)
			AttackTarget(target);
		}
		else
		{
			if (target.transform.position.x < transform.position.x)
			AttackTarget(target);
		}
    }

    void AttackTarget(GameObject target)
    {
        var healthComponent = target.GetComponent<Health>();
		if (healthComponent)
		healthComponent.takeDamage(attackValue);
    }

    IEnumerator OnAttack()
    {
        yield return new WaitForSeconds(attackDelay);
		canAttack = true;
		StartCoroutine(OnAttack());
    }

    void Update () {
		
	}
}
