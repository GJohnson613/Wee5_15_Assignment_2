using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverFuncitons : MonoBehaviour
{
    public GameObject score;
    public GameObject GameOver;
    public GameObject ActiveGame;

    // Start is called before the first frame update
    void Start()
    {
        GameOverMenu();
    }

    public void MainMenuReturn()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Main Menu");
    }

    public void GameOverMenu()
    {
        GameOver.SetActive(true);
        ActiveGame.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
