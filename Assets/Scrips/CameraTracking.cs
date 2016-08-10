using UnityEngine;
using System.Collections;

public class CameraTracking : MonoBehaviour {

	public GameObject player;
	Vector3 offset;


	void Start () 
	{//al iniciar, la variable offset va a ser la posicion del jugador
		offset = transform.position;
	}
	

	void LateUpdate () 
	{//La variable offset se va sumando a la posicion del jugador conforme cambia de posicion
		transform.position = player.transform.position + offset;
	}
}
