using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextSpawner : MonoBehaviour {

    public GameObject spawnee2;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;

	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnText", spawnTime, spawnDelay);
		
	}
	
	// Update is called once per frame
	void SpawnText () {
        Instantiate(spawnee2, transform.position, Quaternion.identity);
        if(stopSpawning){
            CancelInvoke("SpawnText");
        }
		
	}
}
