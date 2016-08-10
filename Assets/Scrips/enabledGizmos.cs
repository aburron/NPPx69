using UnityEngine;
using System.Collections;

public class enabledGizmos : MonoBehaviour 
{
	void OnDrawGizmos()
	{
		Gizmos.color = Color.yellow;
		Gizmos.DrawWireCube (this.transform.position, this.transform.localScale);
	}	
}
