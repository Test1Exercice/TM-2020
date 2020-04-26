using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemymove : MonoBehaviour
{
	public Transform Player;
	public float MoveSpeed = 4;
	public float MinDist = 5;
	public float MaxDist = 10;


	void Start()
	{

	}

	void Update()
	{
		//Moves towrd player
		transform.LookAt(Player);
		if (Vector3.Distance(transform.position, Player.position) >= MinDist)
		{

			transform.position += transform.forward * MoveSpeed * Time.deltaTime;


			if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
			{
				Destroy(this.gameObject);

			}
		}
	}
}