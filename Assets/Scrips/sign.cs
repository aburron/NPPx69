using UnityEngine;
using System.Collections;

public class sign : MonoBehaviour {

	public Transform signBox;
	public GameObject sign1;

	// Use this for initialization
	void Start () {
		sign1.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnDrawGizmos()
	{
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube (signBox.position, signBox.localScale);
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") 
		{
			sign1.SetActive (true);
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Player") 
		{
			sign1.SetActive (false);
		}
	}
}
