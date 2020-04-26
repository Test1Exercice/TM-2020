using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour {

	private float myFloat = 0.05f;


	private Light flashlightLightSource;
	public bool lightOn = true;
	public float lightDrain = 0.1f;
	private static float batteryLife = 0.0f;
	
	public float maxBatteryLife = 2.0f;
	public static float batteryPower = 1;
	
	public float barDisplay = 0;
	public Vector2 pos = new Vector2(20, 40);
	public Vector2 size = new Vector2(60, 20);
	public Texture2D progressBarEmpty;
	public Texture2D progressBarFull;

	private AudioClip soundTurnOn;
	private AudioClip soundTurnOff;

	public FlashLight()
	{
	}

	public static object LightSource { get; private set; }

	void Start()
	{
		batteryLife = maxBatteryLife;
		flashlightLightSource = GetComponent<Light>();
	}


	static void AlterEnergy(int amount)
	{
		batteryLife = Mathf.Clamp(batteryLife + batteryPower, 0, 100);

	}

	internal static void AlterEnergy(float batteryPower)
	{
		throw new NotImplementedException();
	}

	void Update()
	{

		//BATTERY LIFE BRIGHTNESS//////////
		if (lightOn && batteryLife >= 0)
		{
			batteryLife -= Time.deltaTime * lightDrain;
		}
		if (lightOn && batteryLife <= 0.4f)
		{
			GetComponent<Light>().intensity = 5;

		}
		if (lightOn && batteryLife <= 0.3f)
		{
			GetComponent<Light>().intensity = 4;
		}
		if (lightOn && batteryLife <= 0.2f)
		{
			GetComponent<Light>().intensity = 3;
		}
		if (lightOn && batteryLife <= 0.1f)
		{
			GetComponent<Light>().intensity = 2;
		}
		if (lightOn && batteryLife <= 0)
		{
			GetComponent<Light>().intensity = 1;
		}



		barDisplay = batteryLife;

		if (batteryLife <= 0)
		{
			batteryLife = 0;
			GetComponent<Light>().intensity = 0;
		}

		if (Input.GetKeyUp(KeyCode.F))
		{
			toggleFlashlight();

			if (lightOn)
			{
				lightOn = false;
			}
			else if (!lightOn && batteryLife >= 0)
			{
				lightOn = true;
			}
		}
	}

	/////// PIC  ///////////
	void OnGUI()
	{

		// draw the background:
		GUI.BeginGroup(new Rect(pos.x, pos.y, size.x, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), progressBarEmpty);

		// draw the filled-in part:
		GUI.BeginGroup(new Rect(0, 0, size.x * barDisplay, size.y));
		GUI.Box(new Rect(0, 0, size.x, size.y), progressBarFull);
		GUI.EndGroup();

		GUI.EndGroup();

	}

	void toggleFlashlight()
	{
		if (lightOn)
		{
			flashlightLightSource.enabled = false;
		}
		else
		{
			flashlightLightSource.enabled = true;
		}
	}




}