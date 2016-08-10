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
		{//Si la plataforma se encuentra al principio de la animacion, se desactiva el boton
			Switch = false;
		}

		if (transform.position == endTransform.position) 
		{//Si la plataforma se encuentra al final de la animacion, se activa el boton
			Switch = true;
		}

		if (Switch) 
		{//Si el boton esta activado, la plataforma se mueve de su posicion actual al principio de la animacion
			transform.position = Vector3.MoveTowards (transform.position, startTransform.position, speed);
		}
		if (!Switch) 
		{//Si el boton esta desactivado, la plataforma se mueve de su posicion actual al final de la animacion
			transform.position = Vector3.MoveTowards (transform.position, endTransform.position, speed);
		}
	}

	void OnDrawGizmos()
	{
		Gizmos.color = Color.red;
		Gizmos.DrawWireCube (endTransform.position, endTransform.localScale);
		//En caso de ser un Empty GameObject, OnDrawGizmos dibuja en Scene lo resultante a las lineas verdes de un collider
		Gizmos.color = Color.green;
		Gizmos.DrawWireCube (startTransform.position, startTransform.localScale);
	}
}
