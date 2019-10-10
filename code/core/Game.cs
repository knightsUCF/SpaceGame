using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using TMPro;




// main game controller


public class Game : MonoBehaviour
{


    Wave wave;
    Procedural procedural;

	Player2 player;
	public GameObject playerGO;


	// call game start

	void Start()
    {
		player = FindObjectOfType<Player2>();
        wave = FindObjectOfType<Wave>();
        procedural = FindObjectOfType<Procedural>();

        // GameStart();
    }



    // METHODS ///////////////////////////////////////////////////////

    public void GameLoad()
	{
        // load up all universe stuff
	}



    // game start


    public void GameStart()
    {
        // use a seed to generate a galaxy

       procedural.GenerateGalaxy();

		// between this and all the player stuff, throw up a loading text: "LOADING..." at the bottom center, that way we can load everything and have the player wait patiently

		// load player

		playerGO.SetActive(true);
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

public class Done_GameController : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    public Text scoreText;
    public Text restartText;
    public Text gameOverText;

    private bool gameOver;
    private bool restart;
    private int score;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(startWait);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(spawnWait);
            }
            yield return new WaitForSeconds(waveWait);

            if (gameOver)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }

    public void GameOver()
    {
        gameOverText.text = "Game Over!";
        gameOver = true;
    }
}

*/
