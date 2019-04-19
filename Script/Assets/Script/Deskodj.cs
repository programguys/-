using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Deskodj : MonoBehaviour {

    public GameObject WinMenu;
    public GameObject obj;
    public Text txt;
    public string who;
    public string end;
    public static int x;
    public int EndScore;
    Timer timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "pit")
        {
            Deskodj ds1 = new Deskodj();

            Destroy(obj);
            x++;
            txt.text = who + " " + x.ToString() + "| " + end;

            if (x == EndScore)
            {
                WinMenu.SetActive(true);

                Money.wallet += 10;
            }
        }
    }

    void Start()
    {
        x = 0;
    }
}
