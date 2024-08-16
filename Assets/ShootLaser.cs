using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootLaser : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject LaserPrefab;
    float laserSpeed = 5;
    private AudioSource laserSound;

    // Start is called before the first frame update
    void Start()
    {
        laserSound = GameObject.Find("Laser Sound").GetComponent<AudioSource>();
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
        // transform.position = transform.position + moveDirection * laserSpeed * Time.deltaTime;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 playerPosition = transform.position;
        Vector2 aim = mousePosition - playerPosition;
        Vector2 laserVelocity = aim * laserSpeed;
        RaycastHit2D hit = Physics2D.Raycast(FirePoint.position, aim);
        GameObject laserInstance = Instantiate(LaserPrefab, FirePoint.position, Quaternion.identity);
        laserInstance.GetComponent<Rigidbody2D>().velocity = aim * laserSpeed;
        laserSound.Play();
        
    }
}
