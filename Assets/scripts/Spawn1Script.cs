using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn1script : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ships;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StarSpawning());
    }

    IEnumerator StarSpawning()
    {
        yield return new WaitForSeconds(1);
        Instantiate(ships[5], spawnPoints[5].position, Quaternion.identity);

        //yield return new WaitForSeconds(1);
        //Instantiate(ships[0], spawnPoints[0].position, Quaternion.identity);

        //yield return new WaitForSeconds(2);
        //Instantiate(ships[1], spawnPoints[1].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[2], spawnPoints[2].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        yield return new WaitForSeconds(5);
        Instantiate(ships[4], spawnPoints[4].position, Quaternion.identity);

        

        

       
        //yield return new WaitForSeconds(3);
        //Instantiate(ships[1], spawnPoints[1].position, Quaternion.identity);

        //yield return new WaitForSeconds(2);
        //Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        //yield return new WaitForSeconds(3);
        //Instantiate(ships[2], spawnPoints[2].position, Quaternion.identity);

       


        //for (int i = 0; i < 3; i++)
        //{
        //    Instantiate(ships[i], spawnPoints[i].position, Quaternion.identity);
        //}


        yield return new WaitForSeconds(2);
        StartCoroutine(StarSpawning());
    }
}