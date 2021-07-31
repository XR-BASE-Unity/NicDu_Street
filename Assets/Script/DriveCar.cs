using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveCar : MonoBehaviour
{
   public float speed;
   public float angle;
   public ParticleSystem part1;
   public ParticleSystem part2;
   private AudioSource flasher;
   

   void Start()
    {
        flasher = GetComponent<AudioSource>();
    }
	
	//IEnumerator DecreaseSpeed ()
	//{
	//	for (; speed > 800; speed -= Time.deltaTime)
	//		yield return new WaitForSeconds(0.1f);
	//}
	
	void FlasherSoundPlay ()
	{
		if (Input.GetKeyDown(KeyCode.LeftShift) )
		{
			flasher.Play();
		}
		
		if (Input.GetKeyUp(KeyCode.LeftShift) )
		{
			flasher.Stop();
		}
	}

    void Update()
    {
        Vector3 posOffset = gameObject.transform.position;
		Vector3 rotOffset = Vector3.zero;
				
		if (Input.GetKey(KeyCode.W))
		{
			posOffset += Time.deltaTime * speed * gameObject.transform.forward;
			//gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * speed * Time.deltaTime);
			
			if (Input.GetKey(KeyCode.A))
			{
				rotOffset = new Vector3(0f, -Time.deltaTime * angle, 0f);
			}

			if (Input.GetKey(KeyCode.D))
			{
				rotOffset = new Vector3(0f, Time.deltaTime * angle, 0f);
			}
			
			//if (Input.GetKey(KeyCode.LeftShift))
			//{
			//	speed = Mathf.Min(speed + 1f * Time.deltaTime, 2000);
			//}
				
			if (Input.GetKey(KeyCode.LeftShift))
			{
				posOffset += Time.deltaTime * speed * gameObject.transform.forward;
				//StartCoroutine(DecreaseSpeed());
			}
		}
		
		if (Input.GetKey(KeyCode.S))
		{
			posOffset -= Time.deltaTime * speed * gameObject.transform.forward;
			//gameObject.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * speed * Time.deltaTime);
			
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
