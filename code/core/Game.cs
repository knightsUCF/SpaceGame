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
    
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI gameOverText;



    private bool restart;



    void Start()
    {
        restart = false;
        restartText.text = "";
        gameOverText.text = "";

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

        
    }


    IEnumerator SpawnWaves()
    {
        yield return new WaitForSeconds(Settings.START_WAIT);
        while (true)
        {
            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);
                yield return new WaitForSeconds(Settings.SPAWN_WAIT);
            }
            yield return new WaitForSeconds(Settings.WAVE_WAIT);

            if (State.GAME_OVER)
            {
                restartText.text = "Press 'R' for Restart";
                restart = true;
                break;
            }
        }
    }

    public void AddScore(int newScoreValue)
    {
        State.SCORE += newScoreValue;
        UpdateScore();
    }

    void UpdateScore()
    {
        scoreText.text = "Score: " + State.SCORE;
    }

    public void GameOver()
    {
        gameOverText.text = "GAME OVER";
        State.GAME_OVER = true;
    }



    
}
