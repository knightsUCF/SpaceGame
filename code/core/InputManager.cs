class InputManager()
{


  void Update()
      {
          if (restart) // get reference to restart
          {
              if (Input.GetKeyDown(KeyCode.R) || Input.GetButton("Fire1"))
              {
                  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
              }
          }


      }



}
