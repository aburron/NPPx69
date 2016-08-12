using UnityEngine;
using System.Collections;

public class dayNightCycle : MonoBehaviour {

	public float speed;

	void Update () 
	{
		transform.Rotate (Vector3.right * speed * Time.deltaTime);
	}
}
