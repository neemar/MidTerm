using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public Transform followThis; //assign in Inspector
	Vector3 inputVector;
	Rigidbody rbody;
	
	// Use this for initialization
	void Start () {
		rbody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void OnTriggerEnter () {
		inputVector = followThis.position - transform.position;
	
	
	//void FixedUpdate () {
		// "B" - "A" (if you want a vector going from A to B)
		//inputVector = followThis.position - transform.position;
		// Normalize "standardizes" a vector to length 1
		rbody.velocity = Vector3.Normalize ( inputVector ) * 5f;
		Debug.Log ( rbody.velocity.magnitude );
		
	}
}
