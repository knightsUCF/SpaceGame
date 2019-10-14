using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class GenerateStarSystem : MonoBehaviour
{


	public GameObject starGO;

    public GameObject[] planets;


    public Vector3 center = Vector3.zero;

   


    void Start()
	{
		GenerateAStarSystem();
	}



    void GenerateAStarSystem()
	{
		GenerateStar();
		GeneratePlanets();
	}



    void GenerateStar()
	{
		GameObject star = Instantiate(starGO, center, Quaternion.identity, this.transform);
	}



    void GeneratePlanet(float minXRange,
                        float maxXRange,

                        float minYRange,
                        float maxYRange,

                        float minZRange,
                        float maxZRange)
	{
		Vector3 position = new Vector3(Random.Range(minXRange, maxXRange), Random.Range(minYRange, maxYRange), Random.Range(minZRange, maxZRange));
		GameObject planet = Instantiate(planets[Random.Range(0, planets.Length)], position, Quaternion.identity, this.transform);
	}



    /*
     *
     * index = Random.Range (0, spawnPoints.Length);
         currentPoint = spawnPoints[index];
         */


    void GeneratePlanets()
	{
		// generate a planet within a cubic area of 400 width

		GeneratePlanet(-200.0f, 200.0f,
					   -200.0f, 200.0f,
					   -200.0f, 200.0f);

		// generate one more planet

		GeneratePlanet(-200.0f, 200.0f,
					   -200.0f, 200.0f,
					   -200.0f, 200.0f);

		// and another!

		GeneratePlanet(-200.0f, 200.0f,
					   -200.0f, 200.0f,
					   -200.0f, 200.0f);

        // and another!

        GeneratePlanet(-200.0f, 200.0f,
                       -200.0f, 200.0f,
                       -200.0f, 200.0f);
    }
}
