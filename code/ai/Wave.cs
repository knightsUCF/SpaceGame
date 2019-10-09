using System.Collections;
using UnityEngine;





public class Wave : MonoBehaviour
{

    public GameObject[] hazards;
    public Vector3 spawnValues; // x = 5, y = 0, z = 16


    // pause time before the game begins

    public float startWait = 1.0f;


    // pause time between individual object spawns in each wave

    public float spawnWait = 0.75f;


    // pause time between waves

    public float waveWait = 4.0f;



    // number of hazardous objects

    public int hazardCount = 10;







    public IEnumerator SpawnWaves()
    {

        // simply pauses for the seconds in Setting.START_WAIT before the wave first begins

        yield return new WaitForSeconds(startWait);


        while (true)
        {
            Debug.Log("Spawning a new wave"); // send this log out to the panel next to the user in VR


            for (int i = 0; i < hazardCount; i++)
            {
                GameObject hazard = hazards[Random.Range(0, hazards.Length)];
                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
                Quaternion spawnRotation = Quaternion.identity;
                Instantiate(hazard, spawnPosition, spawnRotation);

                // pause between individual object spawn times in each wave

                yield return new WaitForSeconds(spawnWait);
            }

            // pause between waves

            yield return new WaitForSeconds(waveWait);



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
