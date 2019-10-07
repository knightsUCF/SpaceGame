using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;
using TMPro;







public class Level : MonoBehaviour
{


    public TextMeshProUGUI levelText;




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
        /* replace currentLevel with State.CURRENT_LEVEL
        
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
        */


    }




    /*
    
    HazardCount is the number of obstacles, so as we increase levels, let's increase this hazard count by a multiple


    if the score reaches a threshold, and there are no hazards in the area then the flash the level 2
    
    
    */








}
