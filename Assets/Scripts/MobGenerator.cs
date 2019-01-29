using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobGenerator : MonoBehaviour
{
    public GameObject MobPrefab;

    private GameObject instantiatedMob;
    //private Vector2 position = new Vector2(0, 15);

    public void Start()
    {
        Debug.Log("StartSpawning1");
        instantiatedMob = Instantiate(MobPrefab, new Vector2(2f, 4f), Quaternion.identity);
    }
}