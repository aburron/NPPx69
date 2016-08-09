using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour
{
	public float jump;
	public float speed;
	public bool isFalling;
	Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}


	void Update()
	{

		Vector3 amount = Vector3.zero;
		
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
			speed *= 2;
		
		if (Input.GetKey(KeyCode.W))
			amount.x += amount.z = speed;
		
		if (Input.GetKey(KeyCode.S))
			amount.x += amount.z = -speed;
		
		if (Input.GetKey(KeyCode.A))
		{
			amount.x += -speed;
			amount.z += speed;
		}
		
		if (Input.GetKey(KeyCode.D))
		{
			amount.x += speed;
			amount.z += -speed;
		}
		if (Input.GetKey (KeyCode.Space) && isFalling == false) 
		{
			rb.velocity = new Vector3 (0, jump, 0);
			isFalling = true;
		}

		transform.position = Vector3.Lerp(transform.position, transform.position + amount, 0.5f * Time.deltaTime);
	}

	void OnCollisionStay()
	{
		isFalling = false;
	}
}