using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// place on the player object
/*

Two nice free space flight controls. We can use things from both. For now just focus on the astronaut movement, since the ship flight controls are working more or less.

https://assetstore.unity.com/packages/tools/input-management/spaceflight-controls-24532
https://assetstore.unity.com/packages/tools/input-management/keyboard-spaceflight-controller-129389 // i like the smooth StopShip lerp 


*/



public class ShipControls : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject ship;

    public GameObject astronautCamera;
    public GameObject shipCamera;

    GameObject playerGO;

    Spaceflight spaceflight;

    bool occupied = true;
    bool noMovement; // set to false by default




    private void Start()
    {
        spaceflight = FindObjectOfType<Spaceflight>();

        // we should start with putting the ship into stationary mode as the gameplay starts

        spaceflight.MaxSpeed = 0.0f;
    }



    // TOGGLE SPACEBAR TO STOP / START SHIP MOVEMENT
    
    public void StopShip()
    {
        // null check prevents checking more than once

        if (spaceflight == null) spaceflight = FindObjectOfType<Spaceflight>(); // a little slow, store a reference later by passing in the game object

        if (Input.GetKeyDown("space"))
        {
            if (!noMovement) spaceflight.MaxSpeed = 0.0f; // a hacky way of stopping the ship
            if (noMovement) spaceflight.MaxSpeed = 200.0f; // a hacky way of stopping the ship
            noMovement = !noMovement;
        }
    }



    // TOGGLE F TO LEAVE OR ENTER THE SPACESHIP

    public void ToggleBetweenPlayerAndShip()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {

            // exit the ship

            if (occupied)
            {
                Debug.Log("Astronaut is in ship");
                playerGO = Instantiate(astronaut, ship.transform.position, Quaternion.identity, this.transform);

                // turn off the ship camera, turn on the astronaut camera

                shipCamera.SetActive(false);
                astronautCamera.SetActive(true);
            }


            // enter the ship (destroy astronaut prefab)

            if (!occupied)
            {
                Debug.Log("Astronaut is not in ship");

                // turn off astronaut camera, turn on ship camera

                astronautCamera.SetActive(false);
                shipCamera.SetActive(true);

                // destroy the astronaut object, remember to save any settings into state machine data

                Destroy(playerGO);
            }


            occupied = !occupied;

        }
    }



    // check for keyboard input in Update()

    private void Update()
    {
        // check for:

        StopShip();

        ToggleBetweenPlayerAndShip();
    }



}
