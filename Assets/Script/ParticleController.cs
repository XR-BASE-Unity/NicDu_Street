using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    ParticleSystem part;
	
	
    void Start()
    {
        part  = GetComponent<ParticleSystem>();
    }

    void Update()
{
        if (Input.GetKeyDown(KeyCode.W))
		{
			part.Play();
		}
		
		if (Input.GetKeyUp(KeyCode.W))
		{
			part.Stop();
		}
    }
}
