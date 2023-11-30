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
		
		if (musicManager != null)
		{
			// Se la musica non è in riproduzione, ricomincia dall'inizio
			if (!musicManager.GetComponent<AudioSource>().isPlaying)
			{
				musicManager.GetComponent<AudioSource>().Play();
			}
    
			// Assicura che l'oggetto MusicManager persista durante il cambio di scena
			DontDestroyOnLoad(musicManager.gameObject);
		}
		
	}
	public void Exit()
	{
		Application.Quit ();
	}
}

