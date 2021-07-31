using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{
	
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Wall"))
		{
			Debug.Log("It's WALL!");
		}
	}
	
	private void OnTriggerExit(Collider other)
	{
		Debug.Log("Trigger Exit");
	}
}
