﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class buttonControler : MonoBehaviour {

    public int Nextlevel;
    public int Restartlevel;

    // Use this for initialization
    public void ExitGame() {
        Application.Quit();

    }
    public void ContinueGame(GameObject obj){
        obj.GetComponent<Paus>().ispaus = false;
}
    public void Menu()
    {
        SceneManager.LoadScene (0);
    }
    public void NewGame()
    {
        SceneManager.LoadScene(3);
    }
    public void RestartLevel()
    {
        SceneManager.LoadScene(Restartlevel);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(Nextlevel);
    }
}