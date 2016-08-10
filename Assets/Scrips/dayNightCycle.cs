using UnityEngine;
using System.Collections;

public class dayNightCycle : MonoBehaviour {

	public float speed;

	void Update () 
	{//La luz direccional va girando, creando un ciclo de dia y noche
		transform.Rotate (Vector3.right * speed * Time.deltaTime);
	}
}
