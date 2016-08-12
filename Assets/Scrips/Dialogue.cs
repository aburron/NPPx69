using UnityEngine;
using System.Collections;

public class Dialogue : MonoBehaviour 
{
	public GameObject targetPlayer;

	void OnTriggerEnter(Collider coll)
	{
		if (Input.GetKey (KeyCode.E))
		{
			if (coll.tag == "Player")
			{
				targetPlayer.SetActive (true);
			}
		}
	}
}
