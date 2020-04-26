using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int Paper = 0;
    public int paperToWin = 5;        //number to win!

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Paper")
        {
            Paper += 1;
            Debug.Log("Pagina recolhida, numero de paginas = " + Paper);
            Destroy(other.gameObject);
        }
    }

    void OnGUI()
    {
        if (Paper < paperToWin)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "" + Paper + " Paginas");
        }
        else
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, 10, 200, 35), "Paginas foram recolhidas!!");
        }
    }
}