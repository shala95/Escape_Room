using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
    public static int globalScore = 0; // Questa è la variabile globale del punteggio

    public void OnButtonClick(string input)
    {
        
            if (input.Contains("Never"))
            {
                globalScore += 1;
            }
            else if (input.Contains("SomeDay"))
            {
                globalScore += 2;
            }
            else if (input.Contains("Always"))
            {
                globalScore += 3;
            }

        

        SceneManager.LoadScene(input.Split(" ")[1]); //this code splits the string at the space and returns the scene name
    }
}


