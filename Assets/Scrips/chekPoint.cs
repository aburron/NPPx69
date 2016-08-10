using UnityEngine;
using System.Collections;

public class chekPoint : MonoBehaviour {

	public Transform spawnPoint;
	public Color meh;
	public GameObject target;

	void Start ()
	{ 	
		//ACTIVAR EN CASO DE QUERER BORRAR LOS DATOS GUARDADOS
		//PlayerPrefs.DeleteAll (); 

		//Al iniciar el juego, se obtienen las posiciones en XYZ para guardarlos posteriormente
		target.transform.position = new Vector3(PlayerPrefs.GetFloat ("tran.pos.x"), PlayerPrefs.GetFloat ("tran.pos.y"), PlayerPrefs.GetFloat ("tran.pos.z"));



	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") 
		{	//Si el jugador colisiona con el checkpoint, se cambia la posicion del spawn a este
			spawnPoint.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

			//El juego guarda los valores de posicion XYZ 
			PlayerPrefs.SetFloat ("tran.pos.x", transform.position.x);
			PlayerPrefs.SetFloat ("tran.pos.y", transform.position.y);
			PlayerPrefs.SetFloat ("tran.pos.z", transform.position.z);
			//Se cambia el color del checkpoint a verde al ser pulsado
			this.GetComponent<Renderer>().material.color = Color.green;
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Player") 
		{//Vuelve a su antiguo color una vez se deja de pulsar
			this.GetComponent<Renderer>().material.color = meh;
		}
	}
}
