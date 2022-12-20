using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    private bool buttonInRange;
    private bool buttonActivated;
    public AudioClip batterySound;
    private static float batteryPower = 10;

    public GUISkin guiSkin;

    private bool hasPlayed = false;

    void OnTriggerEnter(Collider c)
    {
        buttonInRange = true;

    }
    void OnTriggerExit(Collider c)
    {
        buttonInRange = false;

    }
    void OnGUI()
    {
        if (buttonInRange == true)
        {
            GUI.skin = guiSkin;
            GUI.Label(new Rect(Screen.width / 2 - 50, Screen.height / 2 - 55, 120, 50), "(E) Para Apanhar Bateria");

        }

    }
    void Update()
    {
        if (buttonInRange == true)
        {
            if (Input.GetKeyDown("e"))
            {
                if (!hasPlayed)
                {
                    AudioSource.PlayClipAtPoint(batterySound, transform.position);
                    Destroy(gameObject);
                    hasPlayed = true;

                }

            }

        }

    }
}