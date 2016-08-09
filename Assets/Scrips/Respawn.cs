using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	public Transform respawn;
	public Transform spawnPoint;
	public GameObject player;

	// Use this for initialization
	void OnTriggerEnter (Collider coll) 
	{
		if (coll.tag == "Player")
		{
			player.transform.position = spawnPoint.position;
		}
	}

	void OnDrawGizmos ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (spawnPoint.position, spawnPoint.localScale);

		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (respawn.position, respawn.localScale);
	}
}
