using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPoint = new Vector3(0, 7, 1);
        Instantiate(enemy, spawnPoint, Quaternion.Euler(0, 0, 180));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
