using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel2 : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(1);
    }

}