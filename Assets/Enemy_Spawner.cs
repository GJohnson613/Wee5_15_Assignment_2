using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemy;
    float timeDelay = 3;
    float increment = 0.1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawn());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Spawn ()
    {
        while(true)
        {
            Vector3 spawnPoint = new Vector3(0, 7, 1);
            Instantiate(enemy, spawnPoint, Quaternion.Euler(0, 0, 180));

            yield return new WaitForSeconds(timeDelay);
            timeDelay -= increment;
        }
    }
}
