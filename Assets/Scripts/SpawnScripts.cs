using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScripts : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform[] spawnPoints;
    public GameObject[] ballons;

    int y;
    
    void Start()
    {
        StartCoroutine(StartSpawing());
    }

   IEnumerator StartSpawing()
    {
        yield return new WaitForSeconds(4);
        
        for(int i = 0; i<3; i++)
        { y = Random.Range(0, 8);

            Instantiate(ballons[y], spawnPoints[i].position, Quaternion.identity);
            

        }

        StartCoroutine(StartSpawing());
    }
    
}
