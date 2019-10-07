class WaveSpawner : MonoBehaviour
{

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


}
