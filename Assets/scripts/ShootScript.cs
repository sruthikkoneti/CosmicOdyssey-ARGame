using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShootScript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    public GameObject laser;
    public TextMeshProUGUI scoreTxt;
    private float score;
    

    void Start()
    {
        score = 0;
        laser.SetActive(false);
    }
    public void Shoot()
    {
        RaycastHit hit;
        
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit))
        {
            
            if (hit.transform.name == "Ship1(Clone)" || hit.transform.name == "Ship2(Clone)" || hit.transform.name == "Ship3(Clone)" || hit.transform.name == "Ship4(Clone)" || hit.transform.name == "Ship5(Clone)" | hit.transform.name == "Ship6(Clone)" || hit.transform.name=="MissileSupport_000" || hit.transform.name == "MissileSupport_001" || hit.transform.name == "MissileSupport_002" || hit.transform.name == "MissileSupport_003" || hit.transform.name== "Rocket_000" || hit.transform.name == "Rocket_001" || hit.transform.name == "Rocket_002" || hit.transform.name == "Rocket_003" || hit.transform.name == "T-Fighter" || hit.transform.name== "Exhaust Outlet" || hit.transform.name == "Particle System" || hit.transform.name == "SpaceCruiser")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                score++;
                scoreTxt.text = "Score: " + (int)score;
            }
            if (hit.transform.name == "Ship21(Clone)" || hit.transform.name == "Ship22(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                score--;
                scoreTxt.text = "Score: " + (int)score;
            }

        }
        laser.SetActive(true);
        
        if(score == -5)
        {
            GameManager.GameOver = true;
            Time.timeScale = 0;
        }
    }

  
    public void pass()
    {
        Invoke("Off", 0.2f);
    }

    void Off()
    {
        laser.SetActive(false);
    }
}


