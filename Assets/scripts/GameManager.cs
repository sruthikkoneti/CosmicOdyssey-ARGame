using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject overScreen;

    public static bool GameOver;


    // Start is called before the first frame update
    void Start()
    {
        GameOver = false;
        overScreen.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver)
        {
            overScreen.SetActive(true);
             
        }
    }

    public void retry_1()
    {
       
        SceneManager.LoadScene("game_level01");
        
    }
    public void retry_2()
    {
        SceneManager.LoadScene("game_level02");
      
    }

    public void Quit()
    {
        Application.Quit();
    }
}
