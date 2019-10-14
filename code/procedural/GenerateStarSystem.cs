using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class GenerateStarSystem : MonoBehaviour
{


	public GameObject starGO;

    public GameObject[] planets;


    public Vector3 center = Vector3.zero;

    public float universeRadius = 100.0f;

    public int numberOfPlanets = 10;

   


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




    void GeneratePlanets()
	{
        for (int i = 0; i < numberOfPlanets; i++)
        {

            // geneate a planet within a cubic radius

            GeneratePlanet(-universeRadius, universeRadius,
                       -universeRadius, universeRadius,
                       -universeRadius, universeRadius);
        }
    }
}
