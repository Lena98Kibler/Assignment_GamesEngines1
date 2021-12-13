
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{

    //width of the terrain
    public int width = 500;
    //lenght of the terrain 
    public int height = 500;
    //height of the terrain on the y-axis
    public int depth = 50;

    public float scale = 20f;

    //creating a random terrain each time
    public float offsetX = 100f;
    public float offsetY = 100f;

    void Start()
    {

        offsetX = Random.Range(0f, 9999f);
        offsetY = Random.Range(0f, 9999f);

    }

    void Update()
    {

        //reference to the terrain components so that
        //the terrain data can be changed
        Terrain terrain = GetComponent<Terrain>();

        //accessing terrain data
        terrain.terrainData = GenerateTerrain(terrain.terrainData);

        //animating offsetX over time so that the terrain
        //keeps changing
        offsetX += Time.deltaTime * 0.5f;


    }

    TerrainData GenerateTerrain(TerrainData terrainData)
    {

        terrainData.heightmapResolution = width + 1;

        //populating data
        //setting dimensions of the terrain
        // x = width   y= depth  z = height
        terrainData.size = new Vector3(width, depth, height);

        //modifying the height of each float at a given point on the terrain
        //0, 0 = starting point
        terrainData.SetHeights(0,0,GenerateHeights());

        return terrainData;

    }

    //function that returns 2-dimensional float array 
    float[,] GenerateHeights()
    {
        //creating a grid-like array of floats
        //so that each point on the terrain has a float associated with it
        float[,] heights = new float[width, height];

        //looping through each point 
        for(int x = 0; x < width; x++)
        {

            //looping through the y's
            for(int y = 0; y < height; y ++)
            {

                //the current x and y values will be equal to some perlin noise value
                heights[x, y] = CalculateHeight(x, y);

            }

        }

        return heights;

    }

    //function to generate the perlin noise values
    float CalculateHeight(int x, int y)
    {

        //calculating noise coordinates as decimal place numbers
        //converting them into noise map coordinates
        float xCoord = (float)x / width * scale + offsetX;
        float yCoord = (float)y / height * scale + offsetY;

        return Mathf.PerlinNoise(xCoord, yCoord);



    }
}
