using UnityEngine;
using System.Collections;

public class chekPoint : MonoBehaviour {

	public Transform spawnPoint;
	public Color meh;
	public GameObject target;

	void Start ()
	{
		PlayerPrefs.DeleteAll ();
	target.transform.position = new Vector3(PlayerPrefs.GetFloat ("tran.pos.x"), PlayerPrefs.GetFloat ("tran.pos.y"), PlayerPrefs.GetFloat ("tran.pos.z"));



	}

	void OnTriggerEnter (Collider coll)
	{
		if (coll.tag == "Player") 
		{
			spawnPoint.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);



			PlayerPrefs.SetFloat ("tran.pos.x", transform.position.x);
			PlayerPrefs.SetFloat ("tran.pos.y", transform.position.y);
			PlayerPrefs.SetFloat ("tran.pos.z", transform.position.z);

			this.GetComponent<Renderer>().material.color = Color.green;
		}
	}

	void OnTriggerExit (Collider coll)
	{
		if (coll.tag == "Player") 
		{
			this.GetComponent<Renderer>().material.color = meh;
		}
	}


}
