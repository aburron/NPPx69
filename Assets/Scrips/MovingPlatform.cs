using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public Transform startTransform;
	public Transform endTransform;
	public float speed;
	public bool Switch = false;
	
	void FixedUpdate () 
	{
		if (transform.position == startTransform.position) 
		{
			Switch = false;
		}

		if (transform.position == endTransform.position) 
		{
			Switch = true;
		}

		if (Switch) 
		{
			transform.position = Vector3.MoveTowards (transform.position, startTransform.position, speed);
		}
		if (!Switch) 
		{
			transform.position = Vector3.MoveTowards (transform.position, endTransform.position, speed);
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (endTransform.position, endTransform.localScale);
	}
}
