using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
	public void RestartGame()
	{

		SceneManager.LoadScene(0);
		Time.timeScale = 1;
	}


	public void QuitFromGame()
	{
		Application.Quit();
	}
  
}
