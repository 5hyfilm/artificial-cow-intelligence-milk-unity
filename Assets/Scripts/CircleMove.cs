using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour {

    public float Circlespeed;
    public Vector3 moveVector;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate (Circlespeed, 0, 0);

        if (Input.GetKeyDown("space"))
        {
            StopCoroutine("Update");
        }
		
	}
}
