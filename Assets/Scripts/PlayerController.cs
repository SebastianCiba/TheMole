using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
     public Rigidbody2D player;
     private float gravity;


    void Start ()
    {
        gravity = 20.0f;
        player = GetComponent<Rigidbody2D>();
    }
	
	void FixedUpdate ()
    {

        if (Input.GetKeyDown("right") || Input.GetKeyDown("d"))
        {
            player.transform.position += Vector3.right;

        }

        else if (Input.GetKeyDown("left") || Input.GetKeyDown("a"))
        {
            player.transform.position += Vector3.left;
        }

        else if (Input.GetKeyDown("up") || Input.GetKeyDown("w"))
        {
            player.transform.position += Vector3.up;
        }

        else if (Input.GetKeyDown("down") || Input.GetKeyDown("s"))
        {
            player.transform.position += Vector3.down;
        }

    }
}
