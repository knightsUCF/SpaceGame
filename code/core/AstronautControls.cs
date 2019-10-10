using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class AstronautControls : MonoBehaviour
{

    void Update()
    {
        JetPack();
    }



    void JetPack()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Debug.Log("Activating jet pack!");
        }
    }


}
