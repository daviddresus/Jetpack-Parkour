using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camzoom_control : MonoBehaviour
{
    public Camera zoomcam;
    public float scrollspeed = 10f;
    void start()
    {
        zoomcam = Camera.main;
    }

    void Update()
    {
        //camera distance controll
        if (zoomcam.orthographic && zoomcam.orthographicSize > 2 && zoomcam.orthographicSize < 31)
        {
            zoomcam.orthographicSize -= Input.GetAxis("Mouse ScrollWheel") * scrollspeed;
            if (zoomcam.orthographicSize < 3)
            {
                zoomcam.orthographicSize = 3;
            }
            if (zoomcam.orthographicSize > 30)
            {
                zoomcam.orthographicSize = 30;
            }
        }
        else
        {
            zoomcam.fieldOfView -= Input.GetAxis("Mouse ScrollWheel") * scrollspeed;
        }
    }
}
