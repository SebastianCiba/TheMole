using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Head : MonoBehaviour
{
    public Rigidbody2D player;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rubble"))
        {
            Debug.Log("crash");
            player.gameObject.SetActive(false);
        }
    }
}
