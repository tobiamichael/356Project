using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PUInvincibility : MonoBehaviour {

    public float duration = 3f;

    public GameObject pickupEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Pickup(other));
        }
    }

    IEnumerator Pickup(Collider player)
    {
        GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);

        Destroy(effect, 1.0f);

        PlayerAbilities abilities = player.GetComponent<PlayerAbilities>();
    
        abilities.invincible = true;

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        abilities.invincible = false;

        Destroy(gameObject);
    }
}
