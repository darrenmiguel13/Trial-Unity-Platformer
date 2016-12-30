using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public Transform target;
    float distance = -10;
    float lift = 1.5F;

	// Update is called once per frame
	void Update () {
        //what is the position of the object this script is attached to
        transform.position = target.position + new Vector3(0,lift,distance);
        transform.LookAt(target);
	}
}
