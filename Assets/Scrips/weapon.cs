using UnityEngine;
using System.Collections;

public class weapon : MonoBehaviour 
{
	public GameObject weaponObject;
	public float range;
	private	RaycastHit hit;

	void Update()
	{
		if (Input.GetButtonDown ("Fire1"))
		{
			if (Physics.Raycast (weaponObject.transform.position, weaponObject.transform.forward, out hit, range))
			{
			
					Debug.Log (hit.transform.name);
				
			}
		}
	}
}
