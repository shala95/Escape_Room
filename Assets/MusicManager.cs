using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{

	private static MusicManager instance = null;
    public AudioClip backgroundMusic; // Assumi che questo sia il tuo file audio
    private AudioSource audioSource;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            audioSource = gameObject.AddComponent<AudioSource>();
            audioSource.loop = true;
            // Imposta il file audio per la riproduzione
            audioSource.clip = backgroundMusic;
            // Avvia la riproduzione della musica
            audioSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Altri metodi per controllare la riproduzione della musica
    public void PauseMusic()
    {
        audioSource.Pause();
    }

    public void ResumeMusic()
    {
        audioSource.UnPause();
    }

    public void StopMusic()
    {
        audioSource.Stop();
    }
    
}
