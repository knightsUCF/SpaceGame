using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class CameraArrowMovement : MonoBehaviour
{

    
    public float speed = 1.0f;



    


    void SimpleArrowMovement()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, speed * Time.deltaTime, 0));
        }

    }



    void Update()
    {
        SimpleArrowMovement();
    }


}
