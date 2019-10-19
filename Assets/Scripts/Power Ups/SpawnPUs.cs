using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPUs : MonoBehaviour {

    public Vector3 center;
    public Vector3 size;

    private int randomPU;

    public GameObject[] PUs;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < 7; ++i)
        {
            spawnPUs();
        }
	}
	
	// Update is called once per frame
	void Update () {
	   
	}

    public void spawnPUs()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2), Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.x / 2, size.x / 2));

        randomPU = Random.Range(0,2);

        Instantiate(PUs[randomPU], pos, Quaternion.identity);
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }
}
