﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieCamera : MonoBehaviour {
    float speed = 10;
    float endZ = -20;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.z < endZ)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
	}
}
