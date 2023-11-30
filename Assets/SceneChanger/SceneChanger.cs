using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene (sceneName);
		MusicManager musicManager = Object.FindAnyObjectByType<MusicManager>();
		DontDestroyOnLoad(musicManager.gameObject);
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

