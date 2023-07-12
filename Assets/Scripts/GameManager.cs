using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public GameObject completeLevelUI;
    public GameObject gameOverUI;
    public int numberOfBricks;


    void Start()
    {
        numberOfBricks = GameObject.FindGameObjectsWithTag("Bricks").Length;
    }


    public void gameStart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void gameOver()
    {
        gameOverUI.SetActive(true);
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  

    public void UpdateNumberOfBricks()
    {
        numberOfBricks--;
        if(numberOfBricks <= 0)
        {

            CompleteLevel();
        }
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);

    }





}
