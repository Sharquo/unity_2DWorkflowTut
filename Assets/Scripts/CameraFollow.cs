using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

public GameObject target;
private Transform targetPos;
	void Start () {
		targetPos = target.transform;
	}

	void Update () {
		if (targetPos)
		transform.position = new Vector3(targetPos.position.x, targetPos.position.y, transform.position.z);
		
	}
}
