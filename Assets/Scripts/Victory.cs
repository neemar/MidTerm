using UnityEngine;
using System.Collections;

public class Victory : MonoBehaviour {
	bool playerEntered = false;
	bool friend1Entered = false;
	bool friend2Entered = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (playerEntered && friend1Entered && friend2Entered) {
			Application.LoadLevel ("VictoryScreen");
		}
	
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			playerEntered = true;
		}
		if (other.tag == "Friend1") {
			friend1Entered = true;
		}
		if (other.tag == "Friend2") {
			friend2Entered = true;
		}

	}


}
