using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipBehaviour14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] private Vector3 target = new Vector3(0,-5,-15);
    [SerializeField] private float speed = 3.5f;
    private void Update()
    {
        // Moves the object to target position
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }
  
}
