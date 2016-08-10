using UnityEngine;
using System.Collections;

public class LoadLevelManager : MonoBehaviour 
{
	public GameObject player;
	public GameObject MountainIsland;
	public bool triggerEnabled;

	void Start()
	{
		MountainIsland = GetComponent<GameObject>();
	}
	
	void Update () 
	{
		if (player.transform.position == MountainIsland.transform.position)
		{
			triggerEnabled = true;
		}

		if (triggerEnabled == true) 
		{
			Application.LoadLevel(1);
		}
	}
}