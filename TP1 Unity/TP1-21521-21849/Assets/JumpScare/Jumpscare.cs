using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumpscare : MonoBehaviour
{
	public GameObject scare;
	public bool played = false;
	public bool trig = false;


	public AudioClip scareSound;
	////////Make sure its not visable and reset////////
	void Start()
	{
		var renderer = GetComponent<Renderer>();
		trig = false;
		scare.GetComponent<Renderer>().enabled = false;

	}
	/////When player enters trigger/////// set to true///////
	void OnTriggerEnter(Collider other)
	{
		trig = true;
	}
	//////Enable renderer and trigger sound and timer/////
	void Update()
	{
		if (trig == true)
		{
			scare.GetComponent<Renderer>().enabled = true;
			removeovertime();
			makehimscream();
		}
	}
	//// timer ////
	IEnumerator removeovertime()
	{
		yield return new WaitForSeconds(1.5f);
		scare.GetComponent<Renderer>().enabled = false;
		Destroy(this.gameObject);

	}
	//// sound /////
	void makehimscream()
	{
		if (!played)
		{
			played = true;
			GetComponent <AudioSource>().PlayOneShot(scareSound);
		}
	}

}