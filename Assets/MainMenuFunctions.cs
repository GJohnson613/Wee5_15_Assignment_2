using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuFunctions : MonoBehaviour
{
    public GameObject MainMenu;
    public GameObject Credits;
    private audioManager audioManager;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
        audioManager = FindObjectOfType<audioManager>();
        audioManager.PlayTitleMusic();
    }

    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Game Level");
    }

    public void CreditsButton()
    {
        MainMenu.SetActive(false);
        Credits.SetActive(true);
    }

    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
