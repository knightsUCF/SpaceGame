using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class InputManager : MonoBehaviour
{

    public GameObject player;
    public GameObject oldCamera;

    bool cameraToggle = true;


    public void ToggleBetweenPlayerAndShip()
    {
        if (Input.GetKeyDown("space"))
        {
            oldCamera.SetActive(cameraToggle);
            player.SetActive(!cameraToggle);
            cameraToggle = !cameraToggle;
        }
    }


    public void Close()
    {
        if (Input.GetKey("escape")) 
        {
            Application.Quit();
        }
    }



    void Update()
    {
        ToggleBetweenPlayerAndShip();

        Close();
    }





}
