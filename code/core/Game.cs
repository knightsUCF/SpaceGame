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



    
}
