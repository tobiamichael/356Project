﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotationController : MonoBehaviour {

    public float SENS_HOR = 3.0F;
    public float SENS_VER = 2.0F;
    public float ballVelocity;
    public bool activated = false;
    GameObject character; // a parent object the camera is attached to

    // Start is called before the first frame update
    void Start()
    {
        // disable the mouse cursor
        Cursor.lockState = CursorLockMode.Locked;
        // assign a parent object of this project
        character = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            CannonScript cannonScript = GameObject.Find("launchlocation").GetComponent<CannonScript>();

            //ballVelocity = cannonScript.ballVelocity;

            var mouseMove = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
            mouseMove = Vector2.Scale(mouseMove, new Vector2(SENS_HOR, SENS_VER));
            // rotate the character horizontally
            character.transform.Rotate(0, mouseMove.x, 0);
            //transform.Rotate(-mouseMove.y, 0, 0); // rotate the camera vertically
            transform.localRotation = Quaternion.Euler(-ballVelocity, 0, 0);

            // enable the mouse cursor if Esc pressed
            if (Input.GetKeyDown("escape"))
                Cursor.lockState = CursorLockMode.None;
        }
    }

    public void Activate()
    {
        activated = true;
    }
    public void Deactivate()
    {
        activated = false;
    }
}
