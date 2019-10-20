using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyShoot : MonoBehaviour {

    public Rigidbody cannonballInstance;

    public float ballVelocity;
    public float initialVelocity = 10f;
    public double fireRate = 0.5;

    public double nextFire = 0.0;
    public float chargeCounter = 0;
    public float chargeRate = 0.1f;

    public bool activated;
    public float initialForce = 15;

    // Start is called before the first frame update
    void Start()
    {
        initialForce = 15;
    }

    // Update is called once per frame
    void Update()
    {
        if (activated)
        {
            
            Shoot();
            /*
            if (Input.GetButtonDown("Fire1"))
            {
                Rigidbody clone = Instantiate(cannonballInstance, transform.position, transform.rotation);
                clone.AddForce(transform.forward * initialForce, ForceMode.Impulse);
            }
            */
        }


    }

    // Update is called once per frame
    public void Shoot()
    {
        ballVelocity = 10;
        Rigidbody clone = Instantiate(cannonballInstance, transform.position, transform.rotation);
        clone.AddForce(transform.forward * ballVelocity, ForceMode.Impulse);

        /*
        if (Input.GetButton("Fire1"))
        {

            if (chargeCounter >= 100)
            {
                Debug.Log("fully charged weapon");

            }

            if (chargeCounter <= 100)
            {
                chargeCounter++;
                ballVelocity = 10 + chargeCounter * chargeRate;
            }
        }

        if (Input.GetButtonUp("Fire1"))
        {

            if (chargeCounter >= 100)
            {

                Debug.Log("This was a charged attack");

            }
            if (Time.time > nextFire)
            {
                

                /*
                var instantiatedProjectile : Rigidbody = Instantiate(projectile, transform.position, transform.rotation);

                instantiatedProjectile.velocity = transform.TransformDirection(Vector3(0, 0, speed));

                Physics.IgnoreCollision(instantiatedProjectile.collider, transform.root.collider);

                
                nextFire = Time.time + fireRate;

            }

            chargeCounter = 0;

        } */

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
