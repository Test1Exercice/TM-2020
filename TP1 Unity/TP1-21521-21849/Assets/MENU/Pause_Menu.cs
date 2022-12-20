using System.Linq;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class Pause_Menu : MonoBehaviour
{

    #region Attributs

    private bool isPaused = false;

    #endregion

    #region Proprietes
    #endregion

    #region Constructeur
    #endregion

    #region Methodes

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            isPaused = !isPaused;


        if (isPaused)
            Time.timeScale = 0f;

        else
            Time.timeScale = 1.0f;

    }

    void OnGUI()
    {
        if (isPaused)
        {


            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 - 60, 100, 40), "Continuar"))
            {
                isPaused = false;
            }


            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 00, 100, 40), "Recomeçar"))
            {

                SceneManager.LoadScene(1); ;
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 60, Screen.height / 2 + 60, 100, 40), "Menu Principal"))
            {
                SceneManager.LoadScene(0);




            }

        }
    }

    #endregion
}