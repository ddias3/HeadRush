﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Control: MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	public void NextScene()
	{
		StateManager.curState = 2;
		StateManager.levelStartTimer = 3.0f;
		SceneManager.LoadScene("Level1");
	}

    public static void EndGame()
    {
        SceneManager.LoadScene("EndGame");
    }

    public void MainMenu()
    {
        StateManager.curState = 1;
        SceneManager.LoadScene("Menu");
    }
}


