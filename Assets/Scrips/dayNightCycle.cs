using UnityEngine;
using System.Collections;

public class dayNightCycle : MonoBehaviour {

	public float speed;
	public Material SkyboxDia; //Cielo de dia
	public Material SkyboxNoche; //Cielo noche

	void Update () 
	{//La luz direccional va girando, creando un ciclo de dia y noche
		transform.Rotate (Vector3.right * speed * Time.deltaTime);
	}
	//A partir de aqui es para cambiar el cielo a uno estrellado.

	void Start ()
	{
		StartCoroutine(diawait());
	}
	public void dia()
	{

		RenderSettings.skybox = SkyboxNoche;
		//noche ();
	}
	IEnumerator diawait()
	{
		print("dia");
		yield return new WaitForSeconds(5);
		RenderSettings.skybox = SkyboxNoche;
		StartCoroutine(nochewait());
	}
	IEnumerator nochewait()
	{
		print("noche");
		yield return new WaitForSeconds(5);
		RenderSettings.skybox = SkyboxDia;
		StartCoroutine(diawait());
	}
}
