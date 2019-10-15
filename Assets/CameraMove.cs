using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{

    public float speed = 40;
    public GameObject camera;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        camera.transform.position += Vector3.forward * Time.deltaTime * speed;


    }
}
