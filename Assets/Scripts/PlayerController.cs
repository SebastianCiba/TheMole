using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D player;
    public BoxCollider2D head;
    public Text PointsText;
    public Text BricksText;
    public Text SpeedText;
    private int points;
    private int bricks;

    private MobGenerator MG;

    private void Start ()
    {
        player = GetComponent<Rigidbody2D>();
        head = GetComponent<BoxCollider2D>();

        Debug.Log("Start");
        PointsText.text = "Punkty: " + Environment.NewLine + "0";
        BricksText.text = "Klocki: " + Environment.NewLine + "0";
        SpeedText.text = "Szybkość: " + Environment.NewLine + "0";
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("rubble"))
        {
            Destroy(collision.gameObject);
            points += 20;
            bricks++;
            PointsText.text = "Punkty: " + Environment.NewLine + points;
            BricksText.text = "Klocki: " + Environment.NewLine + bricks;
        }

        if (bricks % 10 == 0)
        {
            SpeedText.text = "Szybkość: " + Environment.NewLine + bricks / 10;
            MG.SetGravity(bricks/100);
        }
    }

    private void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

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
