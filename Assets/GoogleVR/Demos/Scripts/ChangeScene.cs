using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision a)
	{
		if (a.gameObject.tag == "Player") {
			if (Input.GetKeyDown ("r")) {
				SceneManager.LoadScene ("Scene_02");
			}
		}
	}
}
