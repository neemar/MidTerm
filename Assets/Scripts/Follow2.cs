using UnityEngine;
using System.Collections;

public class Follow2 : MonoBehaviour {

	public Transform followPlayer; //assign in Inspector
	Vector3 inputVector;
	Rigidbody rbody;
	float speed = 5f;
	
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		inputVector = followPlayer.position - transform.position;

	}
	
	void FixedUpdate () {
		// "B" - "A" (if you want a vector going from A to B)
		//inputVector = followThis.position - transform.position;
		// Normalize "standardizes" a vector to length 1
		
		rbody.velocity = Vector3.Normalize ( inputVector ) * speed;
		Debug.Log ( rbody.velocity.magnitude );
	}

}