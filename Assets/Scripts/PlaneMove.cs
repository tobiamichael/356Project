using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMove : MonoBehaviour {

    public float speed = 50;
    public GameObject plane;

	// Use this for initialization
	void Start () {
		
	}

    void FixedUpdate()
    {
        Rigidbody rb = plane.GetComponent<Rigidbody>();
        Vector3 vel = rb.velocity;
        Debug.Log(vel.magnitude);
    }

    // Update is called once per frame
    void Update () {
        
            plane.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        
		
	}
}
