using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {

            SceneManager.LoadScene(1);

		}
        if (Input.touchCount>0)
        {
            SceneManager.LoadScene(1);
        }
	}
}
