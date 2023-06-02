using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void level1()
    {
        SceneManager.LoadScene("game_level01");
    }
    public void level2()
    {
        SceneManager.LoadScene("game_level02");
    }
    public void quit()
    {
        Application.Quit();
    }
}
