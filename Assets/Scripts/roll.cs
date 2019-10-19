using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll : MonoBehaviour {

    public float translateSpeed = 5f;
    public float rotationSpeed = 360f;

	// Update is called once per frame
	void Update () {
        transform.Translate(0,0,-translateSpeed * Time.deltaTime);

        transform.GetChild(0).Rotate(Vector3.up * (rotationSpeed * Time.deltaTime));
    }
}
