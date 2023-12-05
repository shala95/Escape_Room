using UnityEngine;

public class Show : MonoBehaviour
{
    public int threshold=2;
    public CoinsCount coinsCount;
    void Start()
    {
        int score = ScoreManager.globalScore;

        if (score <= threshold) 
		{
			coinsCount.maxCoins-=3;
            Destroy(gameObject);
        } 
    }
}    