using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUShrink : MonoBehaviour {

    public float shrinkSize = 2f;
    public float duration = 3f;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(effect, 1.0f);

        player.transform.localScale /= shrinkSize;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        player.transform.localScale *= shrinkSize;

        Destroy(gameObject);
        
    }
}
