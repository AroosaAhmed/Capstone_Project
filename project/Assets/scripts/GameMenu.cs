using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    public GameObject menu;

    public void Update()
    {
        if(menu.activeSelf)
        {
            menu.SetActive(false);
        }
        else
        {
            menu.SetActive(true);
        }
        
    }
    public void restartGame()
    {
        movement.Lives = 5;
        movement.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
     public void mainMenu()
     {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
     }
    
    public void quitGame()
    {
        Application.Quit();
    }
}
