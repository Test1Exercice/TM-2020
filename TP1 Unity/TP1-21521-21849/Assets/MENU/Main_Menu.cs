using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Main_Menu : MonoBehaviour
{
	private bool quit = false;

	void OnMouseEnter()
	{

		gameObject.GetComponent<Renderer>().material.color = Color.red;      //Change Color to red!

	}

	void OnMouseExit()
	{


		gameObject.GetComponent<Renderer>().material.color = Color.white;

	}

	void OnMouseUp()
	{

		if (quit == true)
		{
			Application.Quit();
		}
		else
		{
			SceneManager.LoadScene(1);
		}

	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape))               
		{
			Application.Quit();
		}

	}
}