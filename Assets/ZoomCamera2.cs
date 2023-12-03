using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        int score = ScoreManager.globalScore;

        if (score <= 2) {
            camera.orthographicSize = 3f;//3
        } else if (score <= 5) {
            camera.orthographicSize = 6f;
        } else {
            camera.orthographicSize = 5f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
