using UnityEngine;
using System.Collections;

public class RigidPlaya : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ( Input.GetKey (KeyCode.W) ) {
			transform.Translate ( 0f, 0f, 0.5f ); // does not care about collision
		}
		
		//go backward
		if ( Input.GetKey (KeyCode.S) ) {
			transform.Translate ( 0f, 0f, -0.5f ); // does not respect collision
		}
		
		//float mouseX = Input.GetAxis ( "Mouse X" ); // number from -1 to 1
		//float mouseY = -Input.GetAxis ( "Mouse Y" );
		// when your mouse stays still, it will be = 0f
		// move mouse to right = 1f
		//move mouse to left = -1f
		// rotation: X = "pitch", Y = "yaw (left and right), Z = "roll"\
		if ( Input.GetKey (KeyCode.D ) ) {
			transform.Rotate ( 0f, 5f, 0f );
		}
		if ( Input.GetKey (KeyCode.A ) ) { 
		transform.Rotate ( 0f, -5f, 0f );
		}
	
	}
}
