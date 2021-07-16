using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeCount : MonoBehaviour
{
    public Image[] lives;
    public int livesRemaining;
    public GameObject GameOver;

    public void LoseLife()
    {
        //Decrease the livesremaining
        livesRemaining--;
        //Hide one of the Life count
        lives[livesRemaining].enabled = false;

        if(livesRemaining == 0)
        {
            Debug.Log("Lost");
            GameOver.SetActive(true);
        }
    }



}
