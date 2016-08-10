using UnityEngine;
using System.Collections;

public class sign : MonoBehaviour {

	public Transform signBox;
	public GameObject sign1;

	// Use this for initialization
	void Start () 
	{//Al iniciar el juego, el panel con el texto esta desactivado
		sign1.SetActive (false);
	}
	
	void OnDrawGizmos()
	{//Dibuja el gizmo del area donde se activa el panel con el texto
		Gizmos.color = Color.blue;
		Gizmos.DrawWireCube (signBox.position, signBox.localScale);
	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") 
		{//Si el jugador entra en el area del cartel, se activa el panel con el texto
			sign1.SetActive (true);
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Player") 
		{//Si el jugador sale del area del cartel, se desactiva el panel con el texto
			sign1.SetActive (false);
		}
	}
}
