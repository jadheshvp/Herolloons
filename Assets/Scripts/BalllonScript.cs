using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BalllonScript : MonoBehaviour
{
    
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 0.2f);
       
        
    }
}
