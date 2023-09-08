using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_movement : MonoBehaviour
{
    public GameObject player;
    public float move_speed = 7f;
    private player_collide c;
    void Start()
    {
        c = FindObjectOfType<player_collide>();
    }

    void Update()
    {
        if (c.is_dead == false)
        {
            //get the Input from Horizontal axis
            float horizontalInput = Input.GetAxis("Horizontal");
            //get the Input from Vertical axis
            float verticalInput = Input.GetAxis("Vertical");

            if(Input.GetKeyDown(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0,0,-25);
            }

            if(Input.GetKeyDown(KeyCode.A))
            {
                transform.rotation = Quaternion.Euler(0,0,25);
            }
            
            if(Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
            {
                transform.rotation = Quaternion.Euler(0,0,0);
            }

            //update the position
            transform.position = transform.position + new Vector3(horizontalInput * move_speed * Time.deltaTime, verticalInput * move_speed * Time.deltaTime, 0);
        }
        
    }
}
