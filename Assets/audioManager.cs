using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioManager : MonoBehaviour
{
    [SerializeField] private AudioSource laserSound;
    [SerializeField] private AudioSource explosionSound;

    [SerializeField] private AudioSource lifeLostSound;

    [SerializeField] private AudioSource titleMusic;
    [SerializeField] private AudioSource gameMusic;

    public void PlayTitleMusic()
    {
        titleMusic.Play();
        gameMusic.Stop();
    }

    public void PlayGameMusic()
    {
        gameMusic.Play();
        titleMusic.Stop();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
