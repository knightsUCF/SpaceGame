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
    GameObject astronaut;
    public GameObject ship;

    // public GameObject astronautCamera;
    // public GameObject shipCamera;

    GameObject playerGO;

    Spaceflight spaceflight;

    bool empty = false;
    bool noMovement; // set to false by default


    public GameObject leavingShipAudioSource;
    public GameObject enteringShipAudioSource;




    private void Start()
    {

        // load the astronaut from resources

        // astronaut = Instantiate(Resources.Load("Astronaut") as GameObject);


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

            // astronaut enters the ship

            if (empty)
            {
                enteringShipAudioSource.GetComponent<AudioSource>().Play();


                Debug.Log("Astronaut is not in ship");

                // enable ship flight controls

                spaceflight.allowControls = true;


                // this might be a slow way of doing things -- one fix is to have these game objects all loaded in some far off distance of the universe, and then set their transform to the central play position
                GameObject astronautCamera = GameObject.FindWithTag("AstronautCamera");
                GameObject shipCamera = GameObject.FindWithTag("ShipCamera");
                shipCamera.SetActive(true);
                astronautCamera.SetActive(false);



                // playerGO = Instantiate(Resources.Load("Astronaut") as GameObject, ship.transform.position, Quaternion.identity, this.transform);; ;

                // turn on the ship camera, turn off the astronaut camera

                // shipCamera.SetActive(true);
                // astronautCamera.SetActive(false);


                // destroy the astronaut object, remember to save any settings into state machine data

                // check for null if somehow we try to destroy an astraunaut game object that isn't there the first time

                if (astronaut != null) Destroy(astronaut);
            }


            // astronaut leaves the ship

            if (!empty)
            {
                leavingShipAudioSource.GetComponent<AudioSource>().Play(); // we want to get a reference to this in the future for efficiency

                Debug.Log("Astronaut is in ship");

                // enable ship flight controls

                spaceflight.allowControls = false;

                // if we disable the flight controls, we want to make sure the ship does not keep on moving while the astronaut is exploring

                spaceflight.MaxSpeed = 0.0f;


                // playerGO = Instantiate(astronaut, ship.transform.position, Quaternion.identity, this.transform);
                astronaut = Instantiate(Resources.Load("Astronaut") as GameObject);
                astronaut.transform.position = ship.transform.position;


                // turn on astronaut camera, turn off ship camera

                // astronautCamera.SetActive(true);
                // shipCamera.SetActive(false);

                // this might be a slow way of doing things -- one fix is to have these game objects all loaded in some far off distance of the universe, and then set their transform to the central play position
                GameObject astronautCamera = GameObject.FindWithTag("AstronautCamera");
                GameObject shipCamera = GameObject.FindWithTag("ShipCamera");
                shipCamera.SetActive(false);
                astronautCamera.SetActive(true);
            }


            empty = !empty;

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
