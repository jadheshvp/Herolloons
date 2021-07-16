using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    private int ScenetoLoad;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PlayStart()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Menu()
    {
        ScenetoLoad = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene("MainMenu");
    }

    public void back()
    {
        SceneManager.LoadScene(ScenetoLoad);
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

}
