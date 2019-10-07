using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using TMPro;




// main game controller


public class Game : MonoBehaviour
{


    Wave wave;


    // start up StartGame()

    void Start()
    {
        wave = FindObjectOfType<Wave>();

        StartGame();
    }



    // METHODS ///////////////////////////////////////////////////////

    
    // start game


    void StartGame()
    {
        Debug.Log("Starting game...");

        Debug.Log("Time to first spawn: " + Settings.START_WAIT);
        // spawn enemy AI waves

        StartCoroutine(wave.SpawnWaves());
    }



    // game over

    void GameOver()
    {
        Debug.Log("GAME OVER!");
    }


   
}




/*
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using TMPro;







public class Game : MonoBehaviour
{

    // game settings

    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    


    // text
    
    
    public TextMeshProUGUI gameOverText;



    private bool restart;



    void Start()
    {
        // rewrite all this to be compatible with the new modular files
        
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

        UpdateScore();
        StartCoroutine(SpawnWaves());

        NewLevel(1);
        
        Invoke("ClearLevelText", 2);
        

        
    }

    


    

    

    public void GameOver()
    {
        gameOverText.text = "GAME OVER";
        State.GAME_OVER = true;
    }

*/


    
}
