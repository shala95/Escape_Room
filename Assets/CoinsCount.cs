using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinsCount : MonoBehaviour
{
    public int maxCoins;

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI textMesh = GetComponent<TextMeshProUGUI>();
        textMesh.text = HideWhenClose.globalCoins.ToString();
        if (HideWhenClose.globalCoins >= maxCoins) {
            textMesh.text = "Well done! You finished all the coins";
        }
    }
}
