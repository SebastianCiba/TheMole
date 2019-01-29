using UnityEngine;

public class MobController : MonoBehaviour {

    private float gravity;

    private void Start ()
    {
        gravity = 0.03f;
    }

    private void Update ()
    {
        transform.position -= new Vector3(0, gravity, 0);
    }
}
