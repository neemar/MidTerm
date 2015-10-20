using UnityEngine;
using System.Collections;

public class PatrolCircle : MonoBehaviour {

		//the last point in time when I changed directoin
	float lastTime;

	bool moveForward = false;



	
	// Update is called once per frame
	void Update () {
		//movement code
		if (moveForward) {
			transform.Translate (0f, 0f, 0.1f);
			//if wanna go in circle use transform.RotateAround
		} else {
			transform.Translate (0f, 0f, -0.1f);
		}

		//which way should we move?
		Debug.Log ( Time.time - lastTime );
		if ( Time.time - lastTime > 2f ) {
			moveForward = !moveForward; // "toggle", if its true go to false, if its false go to true. ! = "not"
			lastTime = Time.time;
		}
	}
}
