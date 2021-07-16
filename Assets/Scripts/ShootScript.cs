using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public AudioSource source;
    public AudioClip clip;
   public int num,num2,num3 = 0;
    public Text Score;


    public void Shoot() 
    {
        RaycastHit hit;
        

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "BATMAN(Clone)" || hit.transform.name == "FLASH(Clone)" || hit.transform.name == "HOLLOWMAN(Clone)" || hit.transform.name == "HULK(Clone)" || hit.transform.name == "IRONMAN(Clone)" || hit.transform.name == "JOKER(Clone)" || hit.transform.name == "SPIDERMAN(Clone)" || hit.transform.name == "SRIMS(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                if (hit.transform.name == "BATMAN(Clone)")
                {
                    num += 1;
                    if(SceneManager.GetActiveScene().name == "Level1")
                    {
                        source.PlayOneShot(clip);
                        Score.text = num.ToString("0");
                    }
                    
                    
                }
            

                if (hit.transform.name == "FLASH(Clone)")
                {
                    num2 += 1;
                    if (SceneManager.GetActiveScene().name == "Level2")
                    {
                        source.PlayOneShot(clip);
                        Score.text = num2.ToString("0");
                    }
                }

                if (hit.transform.name == "HULK(Clone)")
                {
                    num3 += 1;
                    if (SceneManager.GetActiveScene().name == "Level3")
                    {
                        source.PlayOneShot(clip);
                        Score.text = num3.ToString("0");
                    }
                }
            }

        }
        


    }

}
