using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleSpawner : MonoBehaviour {

    public GameObject spawnee;
    public bool stopSpawning = false;
	public float spawnTime;
    public float spawnDelay;



	// Use this for initialization
	void Start () {
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
		
	}
	
	// Update is called once per 
	public void SpawnObject () {
        Instantiate(spawnee, transform.position, Quaternion.identity);
        if(stopSpawning) {
            CancelInvoke("SpawnObject");
        }	
	}
}
