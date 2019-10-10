using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class InputManager : MonoBehaviour
{

    public GameObject player;
    public GameObject ship;
    public GameObject oldCamera;

	public GameObject astronaut; // replacing player

    public GameObject shipCamera;
    public GameObject playerCamera;

	public GameObject footstepsAudioSource;


	GameObject playerGO;
    

    bool cameraToggle = true;

    bool isAstronautInShip = true;

	bool halted = false;


	Spaceflight spaceflight;
	ShipControls shipControls;




	private void Start()
    {
        spaceflight = FindObjectOfType<Spaceflight>();
		shipControls = FindObjectOfType<ShipControls>();
    }








    /*
	public void ToggleBetweenPlayerAndShip()
	{
		if (Input.GetKeyDown(KeyCode.F))
		{

            // exit the ship

			if (isAstronautInShip)
			{
				Debug.Log("Astronaut is in ship");
				playerGO = Instantiate(astronaut, ship.transform.position, Quaternion.identity, this.transform);

			}


            // enter the ship (destroy astronaut prefab)

			if (!isAstronautInShip)
			{
				Debug.Log("Astronaut is not in ship");
				Destroy(playerGO);
			}


			isAstronautInShip = !isAstronautInShip;
			
		}
	}
    */












    public void ToggleBetweenPlayerAndShip2()
    {
        /*
        if (Input.GetKeyDown("space"))
        {
            oldCamera.SetActive(cameraToggle);
            player.SetActive(!cameraToggle);
            cameraToggle = !cameraToggle;
        }
        */

        if (Input.GetKeyDown(KeyCode.F))
        {
			isAstronautInShip = !isAstronautInShip;
			Debug.Log("Is astronaut in ship: " + isAstronautInShip);



			/*
            Debug.Log("Attempting to toggle between player and ship");
            // exit the ship - instantiate closely by

            if (isAstronautInShip)
            {
				// slow down ship
				spaceflight = FindObjectOfType<Spaceflight>(); // a little slow, store a reference later by passing in the game object
				spaceflight.MaxSpeed = 0.0f; // a hacky way of stopping the ship, we probably need a method to do this

				playerGO = Instantiate(player, ship.transform.position, Quaternion.identity, this.transform);
                // isAstronautInShip = !isAstronautInShip;
                shipCamera.SetActive(false);
                playerCamera.SetActive(true);
            }

            if (!isAstronautInShip)
            {
				isAstronautInShip = true;
				spaceflight = FindObjectOfType<Spaceflight>(); // a little slow, store a reference later by passing in the game object
				spaceflight.MaxSpeed = 0.0f; // a hacky way of stopping the ship, we probably need a method to do this

				playerCamera.SetActive(false);
                shipCamera.SetActive(true);
                Destroy(playerGO); // any player settings on the player will get erase, better to write to external state machine data
            }
            */

		}
    }

	
    /*
    public void HaltShip()
    {
        spaceflight = FindObjectOfType<Spaceflight>(); // a little slow, store a reference later by passing in the game object


        if (Input.GetKeyDown("space"))
        {
            if (!halted) spaceflight.MaxSpeed = 0.0f; // a hacky way of stopping the ship
            if (halted) spaceflight.MaxSpeed = 200.0f; // a hacky way of stopping the ship
			halted = !halted;
		}
    }
    */


    public void Close()
    {
        if (Input.GetKey("escape")) 
        {
            Application.Quit();
        }
    }




	float timer = 0.0f;
	float timeDelay = 0.5f;

	bool timePassed = false;

	// https://forum.unity.com/threads/how-do-i-calculate-accurately-time-passed-in-seconds-for-c.191434/

    /*
	private void Update()
	{
		_timer += Time.deltaTime;
		if (_timer >= _duration)
		{
			_timer = 0f;
			// Do Stuff here
		}
    }
    */




	public void FootstepsAudio()
	{
        // the player loads later, so ship controls are not available at initialization, this is an inconvenience having something load later, perhaps we should load right away these type of things, and the only things we don't load are the planets and universe generation type stuff

		if (shipControls == null) shipControls = FindObjectOfType<ShipControls>(); 



        // check that if enough time passed, play the sound of footsteps


        timer += Time.deltaTime;

		if (timer >= timeDelay)
		{
			timer = 0f;
			timePassed = true;
		}

		else timePassed = false;


		if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
			&& shipControls.empty == true // check for empty ship, since astronaut will only walk when not in the (empty) ship
			&& timePassed) // we only want to play one sound per whatever
		{
			footstepsAudioSource.GetComponent<AudioSource>().Play();
			// Debug.Log("test");
		}
	}



    void Update()
    {
			FootstepsAudio();
			Close();
    }





}
