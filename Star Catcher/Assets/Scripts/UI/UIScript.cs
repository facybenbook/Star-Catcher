﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
	public float levelTime = 120;

	void Start()
	{
		StaticVars.time = levelTime;	
	}

	public void Pause()
	{
		StaticVars.isPaused = !StaticVars.isPaused;
	}

	public void Restart()
	{
		StaticVars.Reset ();
		SceneManager.LoadScene (1);
	}

	public void MainMenu()
	{
		SceneManager.LoadScene (0);
		StaticVars.isPaused = false;
	}

	public void Quit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#endif

		Application.Quit();
	}
}