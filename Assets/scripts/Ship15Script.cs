using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship15Script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    [SerializeField] private Vector3 target = new Vector3(-1, 1, -100);
    [SerializeField] private float speed = 0.9f;
    private void Update()
    {
        // Moves the object to target position
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }

}
