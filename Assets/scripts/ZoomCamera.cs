using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{   
    public bool zoomOut=false;
    public float low=3.5f;
    public float medium= 2f;
    public float high=1.5f;
    public float zoomValue=2.5f;

    // Start is called before the first frame update
    void Start()
    {
        Camera camera = GetComponent<Camera>();
        int score = ScoreManager.globalScore;

        if (score <= 2) {
            camera.orthographicSize = low;
        } else if (score <= 5) {
            camera.orthographicSize = medium;
        } else {
            camera.orthographicSize = high;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (zoomOut){

            GetComponent<Camera>().orthographicSize+=zoomValue;
            zoomOut=false;
         }   
        
    }
}
