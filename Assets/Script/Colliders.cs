using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
	
	private Rigidbody rb;
	
	
	void Start()
	{
		rb = GetComponent <Rigidbody>();
		//rb.useGravity = false;
		rb.AddTorque(new Vector3(0f, 10f, 0f), ForceMode.Acceleration);
		
	}
	
	
	void Update()
	{
		
	}
	
	void FixedUpdate()
	{
		
	}
	
	
	private void OnTriggerEnter(Collider other)

	{
		if (other.gameObject.CompareTag("Wall"))
		{
			Debug.Log("It's WALL!");
			rb.AddForce(new Vector3(0f, 200f, 0f));
		}
	}
	
	private void OnTriggerExit(Collider other)
		{
			Debug.Log("Trigger Exit");
		}
}
