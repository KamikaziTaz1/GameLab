using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col)
	{
		Debug.Log ("boundary collision");
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("boundary trigger");
		Destroy(other.gameObject);
	}
}
