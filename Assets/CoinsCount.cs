using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CoinsCount : MonoBehaviour
{   
    public string nextScene;
    public int maxCoins;
    
    void Start()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = HideWhenClose.globalCoins.ToString();
    } 

    // Update is called once per frame
    
    void Update()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = HideWhenClose.globalCoins.ToString();
        if (HideWhenClose.globalCoins >= maxCoins) {
            textMesh.text = "Well done! You finished all the coins";
            //we should add delay here 
            SceneManager.LoadScene(nextScene);
        }
    }
}
