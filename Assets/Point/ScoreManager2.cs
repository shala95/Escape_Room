using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class ScoreManager2 : MonoBehaviour
{
    ScoreManager scoreManager = FindObjectOfType<ScoreManager>();

        
        
    public static int globalScore = 0; // Questa è la variabile globale del punteggio
    public static bool premuto = false; // Questa è la variabile globale che tiene traccia se il bottone è stato premuto

    public void OnButtonClick(string buttonName)
    {
        if (!premuto)
        {
            if (buttonName == "Never")
            {
                globalScore += 3;
            }
            else if (buttonName == "SomeDay")
            {
                globalScore += 2;
            }
            else if (buttonName == "Always")
            {
                globalScore += 1;
            }

            premuto = true; // Imposta "premuto" su true dopo aver premuto il bottone
        }
    }
}


