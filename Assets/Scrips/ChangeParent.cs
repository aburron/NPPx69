using UnityEngine;
using System.Collections;

public class ChangeParent : MonoBehaviour {

	public Transform parent;

	void Start()
	{

	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") {
			this.transform.parent = parent;
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Player"){
		this.transform.parent = coll.transform;
	}
	}
}
