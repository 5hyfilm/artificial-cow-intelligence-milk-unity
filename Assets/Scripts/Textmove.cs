using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textmove : MonoBehaviour {

    public float Textspeed;
    public Vector2 moveVector;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Textspeed, 0, 0);
    }
}
