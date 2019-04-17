using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlayer : MonoBehaviour {

    public GameObject LosePanel;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            LosePanel.SetActive(true);

            Time.timeScale = 0;
        }
    }
}
