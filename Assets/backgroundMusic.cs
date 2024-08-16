using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundMusic : MonoBehaviour
{
    private audioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        audioManager = FindObjectOfType<audioManager>();
        audioManager.PlayGameMusic();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
