class InputManager()
{


  void Update()
      {
          if (restart)
          {
              if (Input.GetKeyDown(KeyCode.R) || Input.GetButton("Fire1"))
              {
                  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
              }
          }


      }



}
