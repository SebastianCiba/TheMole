using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;

    private void Start ()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate ()
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
