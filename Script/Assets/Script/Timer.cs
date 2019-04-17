﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour {

    public Text timerText;
    public float StartTime;
    public int a;
    public string EndTime;
    public GameObject LosePanel;

    void Start () {
        StartTime = Time.time;
    }

    void Update () {
        float t = Time.time - StartTime;

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("F0");

        timerText.text = minutes + ":" + seconds;

        if (seconds == EndTime)
        {
            LosePanel.SetActive(true);

            Time.timeScale = 0;
        }

    }
}
