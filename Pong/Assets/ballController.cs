using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {
	public float speed = 100;
	float constantSpeed = 15f;
	public Rigidbody rb;
	// Use this for initialization
	void Start () {
		Vector3 Move = new Vector3(1,0,1);
		rb = this.GetComponent<Rigidbody>();
		rb.AddForce(Move*speed);
	}
	void OnCollisionEnter(Collision col) {
		Vector3 Reset = new Vector3(0,0,-10);
		if (col.gameObject.tag == "wallLeft"){
			transform.position = Reset;
			Vector3 Move = new Vector3(1,0,1);
			rb = this.GetComponent<Rigidbody>();
			rb.AddForce(Move*speed);
		}
		if (col.gameObject.tag == "wallRight"){
			transform.position = Reset;
			Vector3 Move = new Vector3(1,0,1);
			rb = this.GetComponent<Rigidbody>();
			rb.AddForce(Move*speed);
		}
	}
	// Update is called once per frame
	void Update () {
		rb.velocity = constantSpeed * (rb.velocity.normalized);
	}
}
