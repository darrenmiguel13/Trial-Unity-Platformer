using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //when something enters the object
    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "Ball" || other.tag == "Player")
        {
            Debug.Log("coin");
            Destroy(gameObject);
        }
    }
}
