using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_movement : MonoBehaviour
{
    public GameObject player;
    public GameObject cam;

    public float speedxl;
    public float speedxr;
    public float speedyu;
    public float speedyd;

    void Update()
    {
        speedxl = (-player.transform.position.x + cam.transform.position.x);

        speedxr = player.transform.position.x - cam.transform.position.x;

        speedyu = player.transform.position.y - cam.transform.position.y;

        speedyd = (-player.transform.position.y + cam.transform.position.y);

        if (player.transform.position.x < cam.transform.position.x)
        {
            cam.transform.Translate(Vector3.left * (speedxl + 2) * Time.deltaTime / 2);
        }

        if (player.transform.position.x > cam.transform.position.x)
        {
            cam.transform.Translate(Vector3.right * (speedxr + 2) * Time.deltaTime / 2);
        }

        if (player.transform.position.y < cam.transform.position.y)
        {
            cam.transform.Translate(Vector3.down * (speedyd + 2) * Time.deltaTime);
        }

        if (player.transform.position.y > cam.transform.position.y)
        {
            cam.transform.Translate(Vector3.up * (speedyu + 2) * Time.deltaTime);
        }
    }
}
