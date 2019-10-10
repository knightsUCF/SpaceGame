using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class Procedural : MonoBehaviour
{


	public int worldWidth = 10;
	public int worldLength = 10;

	public int objectWidth = 30;
	public int objectLength = 30;

	public float yOffset = -0.8f; // we can randomize this for the procedural generation, along with a z and x offset, only the center of the star system matters for offseting, the rest of the planets are generated relative to the star
	public float zOffset = 1000f;
	public float xOffset = 1000f;


	public GameObject planet; // public GameObject[] FloorTiles;





    void Start()
	{
		// GenerateGalaxy(); // for testing
	}



	public void GenerateGalaxy()
	{
		Debug.Log("Generating galaxy...");

		LayoutObjects(planet);
	}



	void LayoutObjects(GameObject model)
	{
		for (int i = 0; i < worldWidth; i++)
		{
			for (int j = 0; j < worldLength; j++)
			{
				GenerateSpaceObject(model, i, j);
			}
		}
	}



    void GenerateSpaceObject(GameObject model, int i, int j) //  and possibly k for 3D
	{
		GameObject go = Instantiate(model, new Vector3((i * objectLength + xOffset * i), yOffset * i, (j * objectWidth + zOffset * i)), Quaternion.identity, this.transform);
	}


}

/*

		using System.Collections;
		using System.Collections.Generic;
		using UnityEngine;




public class GenerateWorld : MonoBehaviour
	{

		



		void Awake()
		{
			LayoutTiles();
		}



		void GenerateTile(int i, int j)
		{
			GameObject go = Instantiate(FloorTile, new Vector3((i * objectLength), yOffset, (j * objectWidth)), Quaternion.identity, this.transform);
		}



		void LayoutTiles()
		{
			for (int i = 0; i < worldWidth; i++)
			{
				for (int j = 0; j < worldLength; j++)
				{
					GenerateTile(i, j);
				}
			}
		}


	}

}

    */

