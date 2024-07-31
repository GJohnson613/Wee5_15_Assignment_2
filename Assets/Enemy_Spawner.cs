using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 spawnpoint = new Vector3(Random.Range(-9.3f, 9.3f), 9, 0));
        Instantiate(enemy, spawnpoint, transform.rotation);
    }
}
