using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCode : MonoBehaviour
{
    public Vector3 movingDirection;

    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            movingDirection.x = 1;
        }

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            movingDirection.x = -1;
        }

        transform.Translate(movingDirection * Time.deltaTime);
        movingDirection.x = 0;

         if(Input.GetMouseButton(0))
        {

        transform.Rotate(0, 0, 180 * Time.deltaTime);
        }

       if (Input.GetMouseButton(1))

        {
            transform.Translate(2 * Time.deltaTime, 0, 0);
        }

        if(Time.realtimeSinceStartup > 5 && 3 > 0)
        {

        }

        if (Time.realtimeSinceStartup > 5 || 3 > 0)
        {

        }
        
        //transform.Translate(10 * Time.deltaTime, 4 * Time.deltaTime, 3*Time.deltaTime);
        
        //Debug.Log(transform.position);
    }
}
