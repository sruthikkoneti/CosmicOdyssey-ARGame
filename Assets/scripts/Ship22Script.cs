using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipBehaviour7 : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    transform.Translate(Vector3.up*Time.deltaTime*0.3f);
    //    //transform.position = new Vector3(3 * Time.deltaTime,0,0);


    //}



    //void Start()
    //{
    //    // Changes the position to x:1, y:1, z:0
    //    transform.position = new Vector3(1, 1, 0);
    //    // It is also possible to set the position with a Vector2
    //    // This automatically sets the Z axis to 0
    //    transform.position = new Vector2(1, 1);
    //    // Moving object on a single axis
    //    Vector3 newPosition = transform.position; // We store the current position
    //    newPosition.y = 100; // We set a axis, in this case the y axis
    //    transform.position = newPosition; // We pass it back
    //}
    //private void Update()
    //{
    //    // We add +1 to the x axis every frame.
    //    // Time.deltaTime is the time it took to complete the last frame
    //    // The result of this is that the object moves one unit on the x axis every second
    //    transform.position += new Vector3(1 * Time.deltaTime * 0.3f, 1 * Time.deltaTime * 0.3f, 1 * Time.deltaTime * 0.3f);
    //}


    [SerializeField] private Vector3 target = new Vector3(10, 1, 3);
    [SerializeField] private float speed = 3f;
    private void Update()
    {
        // Moves the object to target position
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
    }

}
