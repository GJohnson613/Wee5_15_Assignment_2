using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCounter : MonoBehaviour
{
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    int lifeNumber;
    public GameObject enemy;
    public GameObject collisionSquare;

    // Start is called before the first frame update
    void Start()
    {
        Life1.gameObject.SetActive(true);
        Life2.gameObject.SetActive(true);
        Life3.gameObject.SetActive(true);
        lifeNumber = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("its here");
        if (collision.gameObject.tag == "Enemy")
        {
            updateLives();
        }
    }

    void updateLives()
    {
        lifeNumber -= 1;
        if(lifeNumber == 2)
        {
            Life3.gameObject.SetActive(false);
        }
        if(lifeNumber  == 1)
        {
            Life2.gameObject.SetActive(false);
        }
        if(lifeNumber == 0)
        {
            Life1.gameObject.SetActive(false);
        }
    }
}
