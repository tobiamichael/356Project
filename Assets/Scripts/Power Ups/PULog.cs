using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PULog : MonoBehaviour {

    public GameObject pickupEffect;

    public GameObject logObject;

    Vector3 heightOffset = new Vector3(0, 10, 0);
    Quaternion rotationOffset = Quaternion.Euler(0, 0, 90);

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Pickup(other);
        }
    }

    void Pickup(Collider player)
    {
        GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(effect, 1.0f);

        GameObject log = Instantiate(logObject, player.transform.position + heightOffset, rotationOffset);

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        Destroy(gameObject);
    }
}
