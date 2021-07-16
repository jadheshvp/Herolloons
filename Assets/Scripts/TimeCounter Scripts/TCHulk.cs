using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TCHulk : MonoBehaviour
{
   public float currentTime = 0f;
   public float startingTime = 60f;
   public  ShootScript S;
   public GameObject GameOver;
   public GameObject YouWon;



    public Text Timetext;

    public void CheckShoot()
    {
        int r = S.num3;
        if (r < 7)
        {
            GameOver.SetActive(true);
        }
        else
        {
            YouWon.SetActive(true);
        }
    }

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        StartCoroutine(Wait());

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3);
        currentTime -= 1 * Time.deltaTime;
        Timetext.text = currentTime.ToString("0");
        if (currentTime <= 0)
        {
            currentTime = 0;
            CheckShoot();


        }
    }
}
