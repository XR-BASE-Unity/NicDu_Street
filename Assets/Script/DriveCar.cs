using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
   public float speed;
   public float angle;
   public ParticleSystem part;
   private AudioSource flasher;
   

   void Start()
    {
        flasher = GetComponent<AudioSource>();
    }


    void Update()
    {
        Vector3 posOffset = gameObject.transform.position;
		Vector3 rotOffset = Vector3.zero;
				
		if (Input.GetKey(KeyCode.W))
		{
			posOffset += Time.deltaTime * speed * gameObject.transform.forward;

			if (Input.GetKey(KeyCode.A))
			{
				rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
			}

			if (Input.GetKey(KeyCode.LeftShift))
			{
				posOffset += Time.deltaTime * speed * gameObject.transform.forward;
			}
			
			if (Input.GetKeyDown(KeyCode.LeftShift) )
			{
				flasher.Play();
				part.Play();
			}
		
				if (Input.GetKeyUp(KeyCode.LeftShift) )
			{
				flasher.Stop();
				part.Stop();
			}

			
			
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			posOffset -= Time.deltaTime * speed * gameObject.transform.forward;

			if (Input.GetKey(KeyCode.D))
			{
				rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
			}

			if (Input.GetKey(KeyCode.A))
			{
				rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
			}
		}
		

		
		if (Input.GetKey(KeyCode.UpArrow))
		{
			posOffset += Time.deltaTime * speed * gameObject.transform.forward;
			
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
			}
		
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
			}
		}
		
		if (Input.GetKey(KeyCode.DownArrow))
		{
			posOffset -= Time.deltaTime * speed * gameObject.transform.forward;
			
			if (Input.GetKey(KeyCode.RightArrow))
			{
				rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
			}
		
			if (Input.GetKey(KeyCode.LeftArrow))
			{
				rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
			}
		}
		

		
		gameObject.transform.position = posOffset;
		gameObject.transform.Rotate(rotOffset);
    }
}
