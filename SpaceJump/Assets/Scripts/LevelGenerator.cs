using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{

    public GameObject platformPrefab; //anafora sta platforms
    public GameObject BigPlat; // anafora sta special platforms

    public int numberofPlatforms = 200; // arithomos twn platfroms pou tha ginoun generate(exei allaksei mesa apo to unity)
    
    
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawnPosition = new Vector3(); // vector gia tis nees theseis twn platforms

        for(int i = 0; i<numberofPlatforms; i++) 
        {
            spawnPosition.y += 1 + Random.Range(.5f,2f); // thsi toy platform sto aksona y
            spawnPosition.x = Random.Range(-3.5f,3.5f); //  thesi toy platforms ston aksona x
            // an i pithanonita == 1 tote kane generate ena special platform
            if(Random.Range(1,5) < 2 )
            {
                Instantiate(BigPlat, spawnPosition, Quaternion.identity);
            }
            else
            {
                // alliws gia pitanotita >=2 kai <=5  kane generate ena kanoniko platform
                Instantiate(platformPrefab, spawnPosition, Quaternion.identity);

            }

        }
        
    }

}
