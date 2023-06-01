using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn2script : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] ships;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning2());
    }

    IEnumerator StartSpawning2()
    {
        //yield return new WaitForSeconds(1);
        //Instantiate(ships[0], spawnPoints[0].position, Quaternion.identity);

        //yield return new WaitForSeconds(2);
        //Instantiate(ships[1], spawnPoints[1].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[7], spawnPoints[7].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[2], spawnPoints[2].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[4], spawnPoints[4].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[5], spawnPoints[5].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[6], spawnPoints[6].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[4], spawnPoints[4].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[7], spawnPoints[7].position, Quaternion.identity);

        yield return new WaitForSeconds(1);
        Instantiate(ships[3], spawnPoints[3].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        Instantiate(ships[6], spawnPoints[6].position, Quaternion.identity);

        yield return new WaitForSeconds(2);
        StartCoroutine(StartSpawning2());
    }
}