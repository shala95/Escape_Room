using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowObst : MonoBehaviour
{
    public ScoreManager scoreManager; // Assicurati di assegnare lo script ScoreManager nell'Editor di Unity
    public int threshold = 6;

    void Start()
    {
        // Controlla se lo ScoreManager è stato assegnato
        if (scoreManager != null)
        {
            int globalScore = scoreManager.globalScore_2; // Leggi il valore di globalScore dallo ScoreManager

            // Verifica se globalScore è maggiore della soglia (threshold)
            if (globalScore > threshold)
            {
                // Se globalScore supera la soglia, distruggi il GameObject a cui è collegato questo script
                Destroy(gameObject);
            }
        }
        else
        {
            Debug.LogError("Lo ScoreManager non è stato assegnato al componente CheckScore.");
        }
    }
}
