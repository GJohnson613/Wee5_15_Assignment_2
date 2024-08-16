using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float speed = 15.0f;
    public GameObject explosion;
    private AudioSource explosionSound;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
        explosionSound = GameObject.Find("Explosion Sound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Bullet hit enemy");

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (collision.gameObject.tag == "Enemy")
        {
            var collisionPoint = collision.ClosestPoint(transform.position);
            Instantiate(explosion, collisionPoint, Quaternion.identity);
            
            Destroy(collision.gameObject);
            explosionSound.Play();

        }

        gameObject.SetActive(false);
        Destroy(gameObject);
        
    }
}
