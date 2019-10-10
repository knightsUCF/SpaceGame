using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class CameraManager : MonoBehaviour
{
    public GameObject shipCamera;
    public GameObject playerCamera;



    public void ActivateShipCamera()
    {
        playerCamera.SetActive(false);
        shipCamera.SetActive(true);
    }


    public void ActivatePlayerCamera()
    {
        shipCamera.SetActive(false);
        playerCamera.SetActive(true);
    }
}
