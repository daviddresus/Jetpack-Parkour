using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_collide : MonoBehaviour
{
    private Animator anim;
    public bool is_dead = false;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Walls")
        {
            if (other.transform.position.x > transform.position.x)
            {
                Debug.Log("right Wall detected!");
            }

            if (other.transform.position.x < transform.position.x)
            {
                Debug.Log("left Wall detected!");
            }

            if (other.transform.position.y > transform.position.y)
            {
                Debug.Log("top Wall detected!");
            }
        }

        if (other.gameObject.tag == "Spike")
        {
            is_dead = true;
            anim.Play("explosion");
            Destroy(gameObject, 2f);
        }
    }
}
