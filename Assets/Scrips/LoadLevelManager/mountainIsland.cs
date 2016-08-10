using UnityEngine;
using System.Collections;

public class mountainIsland : MonoBehaviour 
{
	void OnTriggerEnter()
	{
		Application.LoadLevel (1);
	}
}
