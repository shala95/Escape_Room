using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger6 : MonoBehaviour
{
    public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene ("Level_1");
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

