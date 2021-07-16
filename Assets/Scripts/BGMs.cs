using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMs : MonoBehaviour
{
    private static BGMs bgm;

     void Awake()
    { 
        if(bgm == null)
        {
            bgm = this;
            DontDestroyOnLoad(bgm);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
