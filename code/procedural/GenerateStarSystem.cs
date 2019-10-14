using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class GenerateStarSystem : MonoBehaviour
{


	public GameObject starGO;

	public GameObject planet1GO;
	public GameObject planet2GO;
  

	public Vector3 center = Vector3.zero;

   


    void Start()
	{
		// generate a star system

		GenerateAStarSystem();
	}



    void GenerateAStarSystem()
	{
		GenerateStar();
		GeneratePlanets();
	}



	// now pick a randomized position out of a range
    // get random from range:
	// Random.Range(-10.0f, 10.0f)




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
		GameObject planet = Instantiate(planet1GO, position, Quaternion.identity, this.transform);
	}



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

	}
}
