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
		{//Si el jugador se cae del nivel, activa el respawn y lo devuelve al ultimo checkpoint
			player.transform.position = spawnPoint.position;
		}
	}

	void OnDrawGizmos ()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (spawnPoint.position, spawnPoint.localScale);
		//dibuja el area de respawn, y la del spawnPoint
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (respawn.position, respawn.localScale);
	}
}
