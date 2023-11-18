using System.Collections;
using System.Collections.Generic;
using UnityEngine;  
using UnityEngine.UI;
using TMPro;

public class PrintScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score=ScoreManager.globalScore;
        TextMeshProUGUI textMesh=GetComponent<TextMeshProUGUI>();
        textMesh.text=score.ToString();

    }

    
}
