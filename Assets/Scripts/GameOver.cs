using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public void RestartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void NextlevelButton()
    {
        int x = SceneManager.GetActiveScene().buildIndex + 1 ;
        SceneManager.LoadScene(x);
      
    }

    public void ExitButton()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

