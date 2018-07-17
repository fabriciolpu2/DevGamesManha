using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerGame : MonoBehaviour {

public GameObject player;	
public GameObject spawnPoint;
// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("r")) {
			print("Restart");

}
		
	}
}
