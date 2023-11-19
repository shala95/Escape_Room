using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        int score = ScoreManager.globalScore;

        if (score <= 3) {
            camera.orthographicSize = 4.5f;
        } else if (score <= 6) {
            camera.orthographicSize = 3f;
        } else {
            camera.orthographicSize = 1f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
