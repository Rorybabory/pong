using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle1Controller : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow)){
			  transform.Translate(-Time.deltaTime*8,0,0);
		}
		if (Input.GetKey(KeyCode.DownArrow)){
        transform.Translate(Time.deltaTime*8,0,0);
		}
	}
}
