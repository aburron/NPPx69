using UnityEngine;
using System.Collections;

public class fall : MonoBehaviour {

	Rigidbody rb;

	// Use this for initialization
	void Start () {
	 rb = GetComponent <Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			rb.isKinematic = false;
		}
	}
}
