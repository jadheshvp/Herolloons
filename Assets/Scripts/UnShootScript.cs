using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UnShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public LifeCount L;
    public AudioSource source;
    public AudioClip clip;

    public void Shoot1() 
    {
        RaycastHit hit;
        

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "BATMAN(Clone)" || hit.transform.name == "FLASH(Clone)" || hit.transform.name == "HOLLOWMAN(Clone)" || hit.transform.name == "HULK(Clone)" || hit.transform.name == "IRONMAN(Clone)" || hit.transform.name == "JOKER(Clone)" || hit.transform.name == "SPIDERMAN(Clone)" || hit.transform.name == "SRIMS(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

                if (SceneManager.GetActiveScene().name == "Level1")
                {

                    if (hit.transform.name != "BATMAN(Clone)" || hit.transform.name == "FLASH(Clone)" || hit.transform.name == "HOLLOWMAN(Clone)" || hit.transform.name == "HULK(Clone)" || hit.transform.name == "IRONMAN(Clone)" || hit.transform.name == "JOKER(Clone)" || hit.transform.name == "SPIDERMAN(Clone)" || hit.transform.name == "SRIMS(Clone)")
                    {
                        
                        L.LoseLife();
                        if (SceneManager.GetActiveScene().name == "Level1")
                        {
                            source.PlayOneShot(clip);
                        }

                    }
                }

                if(SceneManager.GetActiveScene().name == "Level2")
                {

                    if (hit.transform.name == "BATMAN(Clone)" || hit.transform.name != "FLASH(Clone)" || hit.transform.name == "HOLLOWMAN(Clone)" || hit.transform.name == "HULK(Clone)" || hit.transform.name == "IRONMAN(Clone)" || hit.transform.name == "JOKER(Clone)" || hit.transform.name == "SPIDERMAN(Clone)" || hit.transform.name == "SRIMS(Clone)")
                    {
                        L.LoseLife();
                        if (SceneManager.GetActiveScene().name == "Level2")
                        {
                            source.PlayOneShot(clip);
                        }
                    }
                }

                if (SceneManager.GetActiveScene().name == "Level3")
                {

                    if (hit.transform.name == "BATMAN(Clone)" || hit.transform.name == "FLASH(Clone)" || hit.transform.name == "HOLLOWMAN(Clone)" || hit.transform.name != "HULK(Clone)" || hit.transform.name == "IRONMAN(Clone)" || hit.transform.name == "JOKER(Clone)" || hit.transform.name == "SPIDERMAN(Clone)" || hit.transform.name == "SRIMS(Clone)")
                    {
                        L.LoseLife();
                        if (SceneManager.GetActiveScene().name == "Level3")
                        {
                            source.PlayOneShot(clip);
                        }
                    }
                }
            }

        }
        


    }

}
