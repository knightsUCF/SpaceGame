using System.Collections;
using UnityEngine;





public class Wave : MonoBehaviour
{




    public IEnumerator SpawnWaves()
    {

        // simply pauses for the seconds in Setting.START_WAIT before the wave first begins

        yield return new WaitForSeconds(Settings.START_WAIT);


        while (true)
        {
            for (int i = 0; i < Settings.HAZARD_COUNT; i++)
            {
                Debug.Log("Spawning waves: " + i);

                // pause between individual object spawn times in each wave

                yield return new WaitForSeconds(Settings.SPAWN_WAIT);
            }

            // pause between waves

            yield return new WaitForSeconds(Settings.WAVE_WAIT);



        }






        /*
        
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
        */
    }
     
   
}
