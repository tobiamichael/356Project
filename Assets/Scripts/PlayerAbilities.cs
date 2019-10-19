using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour {

    public bool invincible = false;

    public GameObject absurbEffect;

    /*
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            Instantiate(absurbEffect, collision.gameObject.transform.position, collision.gameObject.transform.rotation);

            Destroy(collision.gameObject);
        }
    }
    */

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Projectile") && invincible == true)
        {
            GameObject absurbed = Instantiate(absurbEffect, other.gameObject.transform.position, other.gameObject.transform.rotation);

            Destroy(absurbed, 1.0f);

            Destroy(other.gameObject);
        }
    }
}
