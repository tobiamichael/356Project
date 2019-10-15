using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour {
	public Transform[] waypoints;
	private int currentPoint = 0;
	private Vector3 target;
	private Vector3 direction;
	Animator charAnim;

	void Start () {
		charAnim = GetComponent<Animator>();
	}
	

	void Update () {
		if (currentPoint < waypoints.Length) {
			target = waypoints[currentPoint].position;
			direction = target - transform.position;
			if (direction.magnitude < 1)
				currentPoint++;

		} 
		else
			currentPoint = 0;

		transform.LookAt (target);
		transform.Translate (0, 0, 0.1f);
		charAnim.SetTrigger("walk");
	}
}
