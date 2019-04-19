using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paus : MonoBehaviour {

    [HideInInspector]
    public bool ispaus;
    [SerializeField]
    private GameObject pausepanel;
    
    
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ispaus = !ispaus;
        }
        if (ispaus)
        {
            pausepanel.SetActive(true);

            Time.timeScale = 0;
        }
        else
        {
            pausepanel.SetActive(false);

            Time.timeScale = 1;
        }
	}
}
