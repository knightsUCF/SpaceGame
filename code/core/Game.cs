using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
// add "using TMPro;" to top of script and use a "TextMeshProUGUI" variable instead of a "Text" one
using TMPro;


public class Game : MonoBehaviour
{
    public GameObject[] hazards;
    public Vector3 spawnValues;
    public int hazardCount;
    public float spawnWait;
    public float startWait;
    public float waveWait;

    // public Text scoreText;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI levelText;
    public Text restartText;
    // public Text gameOverText;
    public TextMeshProUGUI gameOverText;


    private bool gameOver;
    private bool restart;
    private int score;

    public int currentLevel = 1;

    void Start()
    {
        gameOver = false;
        restart = false;
        restartText.text = "";
        gameOverText.text = "";
        score = 0;
        UpdateScore();
        StartCoroutine(SpawnWaves());

        NewLevel(1);
        
        Invoke("ClearLevelText", 2);

        
    }

    void Update()
    {
        if (restart)
        {
            if (Input.GetKeyDown(KeyCode.R) || Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }

        CheckIfToAdvanceToNextLevel();
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
        gameOverText.text = "GAME OVER";
        gameOver = true;
    }


    public void NewLevel(int level)
    {
        levelText.text = "LEVEL " + level.ToString();
    }



    void ClearLevelText()
    {
        levelText.text = "";
    }


    void CheckIfToAdvanceToNextLevel()
    {
        if (score > 300 && currentLevel == 1)
        {
            currentLevel = 2;
            NewLevel(2);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 600 && currentLevel == 2)
        {
            currentLevel = 3;
            NewLevel(3);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 900 && currentLevel == 3)
        {
            currentLevel = 4;
            NewLevel(4);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 1200 && currentLevel == 4)
        {
            currentLevel = 5;
            NewLevel(5);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 1500 && currentLevel == 5)
        {
            currentLevel = 6;
            NewLevel(6);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 1800 && currentLevel == 6)
        {
            currentLevel = 7;
            NewLevel(7);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 2100 && currentLevel == 7)
        {
            currentLevel = 8;
            NewLevel(8);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 2400 && currentLevel == 8)
        {
            currentLevel = 9;
            NewLevel(9);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }

        if (score > 2700 && currentLevel == 9)
        {
            currentLevel = 10;
            NewLevel(10);
            Invoke("ClearLevelText", 2);
            hazardCount = hazardCount * 2;
        }


    }




    /*
    
    HazardCount is the number of obstacles, so as we increase levels, let's increase this hazard count by a multiple


    if the score reaches a threshold, and there are no hazards in the area then the flash the level 2
    
    
    */
}
