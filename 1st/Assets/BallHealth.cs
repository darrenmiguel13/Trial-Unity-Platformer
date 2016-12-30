using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallHealth : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    public float maxFalldis = -10;
	// Update is called once per frame
	void Update () {
		if(transform.position.y <= maxFalldis)
        {
            SceneManager.LoadScene("Level1");
        }
	}
}
