using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger5 : MonoBehaviour
{
    public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene ("AYR");
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

