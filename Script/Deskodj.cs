using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Deskodj : MonoBehaviour
{

    public GameObject obj;
    public Text txt;
    public static int x;
    public int y;

    void OnTriggerEnter(Collider other)
    {
        Deskodj ds1 = new Deskodj();
        Deskodj ds2 = new Deskodj();
        Deskodj ds3 = new Deskodj();
        Destroy(obj);
        x++;
        txt.text = "шаров в лунке" + " " + x.ToString() + "| 7";


        if (x == 7)
        {
            SceneManager.LoadScene(y);

            x = 0;
        }
    }
}
