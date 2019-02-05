using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobGenerator : MonoBehaviour
{
    private int iRubble;
    private int interval;
    private float gravity = 0.1f;

    public Rigidbody2D[] rubble;

    public void SetGravity(float g)
    {
        gravity = g;
    }

    public void Update()
    {
        interval++;
        if (interval > 30)
        {
            interval = 0;
            iRubble = Random.Range(0, 5);
            Instantiate(rubble[iRubble], new Vector2(Random.Range(-7, 7), Random.Range(12, 36)), Quaternion.identity);
            rubble[iRubble].gravityScale = gravity;
        }
        
    }
}