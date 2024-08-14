using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserMovement : MonoBehaviour
{
    public float speed = 15.0f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1f);
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
            var collisionPoint = GetComponent<Collider>().ClosestPoint(transform.position);
            Instantiate(explosion, collisionPoint, Quaternion.identity);
            
            Destroy(collision.gameObject);
        }

        gameObject.SetActive(false);
        Destroy(gameObject);
        
    }
}
