using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject LaserPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        //Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(FirePoint.position, FirePoint.right);
        GameObject laserInstance = Instantiate(LaserPrefab, FirePoint.position, Quaternion.identity);
    }
}