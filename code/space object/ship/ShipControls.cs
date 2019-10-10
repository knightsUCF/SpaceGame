using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// place on the player object



public class ShipControls : MonoBehaviour
{
    public GameObject astronaut;
    public GameObject ship;

    public GameObject astronautCamera;
    public GameObject shipCamera;


    Spaceflight spaceflight;


    // bool occupied = false;


    bool noMovement; // set to false by default




    private void Start()
    {
        spaceflight = FindObjectOfType<Spaceflight>();
    }



    
    public void StopShip()
    {
        spaceflight = FindObjectOfType<Spaceflight>(); // a little slow, store a reference later by passing in the game object

        if (Input.GetKeyDown("space"))
        {
            if (!noMovement) spaceflight.MaxSpeed = 0.0f; // a hacky way of stopping the ship
            if (noMovement) spaceflight.MaxSpeed = 200.0f; // a hacky way of stopping the ship
            noMovement = !noMovement;
        }
    }



    private void Update()
    {
        // check for:

        StopShip();
    }



}
