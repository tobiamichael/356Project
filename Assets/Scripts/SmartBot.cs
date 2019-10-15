using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartBot : MonoBehaviour {

    private Transform playerTransf;
    private Animator botAnimator;

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.FindWithTag("Player");
        playerTransf = player.GetComponent<Transform>();

        botAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = playerTransf.position - this.transform.position;
        float angleOfView = Vector3.Angle(direction, this.transform.forward);

        direction.y = 0;

        // 80 degree cone
        if (angleOfView < 40)
        {
            // 10 units from player
            if (direction.magnitude < 10)
            {
                this.transform.rotation = Quaternion.LookRotation(direction);

                // attack if less than 1 unit away, otherwise run
                if (direction.magnitude < 1)
                {
                    botAnimator.SetTrigger("attack");
                    this.transform.Translate(0, 0, 0.04F);
                }
                else
                {
                    botAnimator.SetTrigger("run");
                    this.transform.Translate(0, 0, 0.2F);
                }
            }
            else
            {
                botAnimator.SetTrigger("idle");
            }
        }
	}
}
