using UnityEngine;

public class GameController : MonoBehaviour {

    //private float gravity;
    //public GameObject rubble;
    //public Rigidbody2D player;

    private void Start ()
    {
        //gravity = 20.0f;
        //player = new Rigidbody2D();
        //player = GetComponent<Rigidbody2D>();
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("rubble"))
        {
            Destroy(collision.gameObject);
        }
        
        //collision.gameObject.SetActive(false);
    }

    //public void OnTriggerEnter2D(Collider collision)
    //{
    //    Destroy(collision.gameObject);
    //    collision.gameObject.SetActive(false);
    //}

    private void Update ()
    {
        //if (FindObjectOfType(typeof(BoxCollider2D)))
        //{
        //    gameObject.transform.position -= new Vector3(0,0.01f,0);
        //}

        //transform.position -= new Vector3(0, 0.01f, 0);
    }
}
