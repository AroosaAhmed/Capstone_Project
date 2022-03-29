using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameEnd : MonoBehaviour
{
    public Text GameEndScore;


    // Update is called once per frame
    void Update()
    {
        GameEndScore.text = movement.Score.ToString();
    }
    public void restartGame()
    {
        movement.Lives = 5;
        movement.Score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -1);
    }
    public void mainMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
    }
}
