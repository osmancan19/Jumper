using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    private Queue<GameObject> platformQueue;
    public GameObject platformPrefab;
    private GameObject temp;
    private int numberOfPlatforms = 5;
	public float levelWidth = 3f;
    Vector3 spawnPosition = new Vector3();


    public Transform player;
    private float currentPosition;//current position 
    private float exPosition;//exposition
    private bool firstTimeOnDelete = true;


    // Use this for initialization
    void Start () {
        
        exPosition = player.position.y;

        platformQueue = new Queue<GameObject>();

        spawnPosition.y = exPosition;
        
        for (int i = 0; i < numberOfPlatforms + 5; i++)  // baslangicta 10 platform.
        {
            
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            temp = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platformQueue.Enqueue(temp);
            spawnPosition.y += 1.86f;

        } 

	}

    void Update()
    {

        currentPosition = player.position.y;

        if ((currentPosition - exPosition) >= numberOfPlatforms*1.86f)
        {
          
            exPosition = currentPosition;
            makeTen();
            deleteTen();

        }

    }

    private void makeTen()
    {

        spawnPosition.y = currentPosition + 5*1.86f;   //ekledigimiz fazladan 5 platform yukarisi olacak sekilde ayarliyoruz.

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            temp = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platformQueue.Enqueue(temp);
            spawnPosition.y += 1.86f; //Random.Range(minY, maxY);

        }

    }

    private void deleteTen()
    {

        if(firstTimeOnDelete == true)
        {

            firstTimeOnDelete = false;

            for (int i = 0; i < numberOfPlatforms - 2; i++)
            {

                temp = platformQueue.Dequeue();
                Destroy(temp);

            }

        }
        else
        {

            for (int i = 0; i < numberOfPlatforms ; i++)
            {

                temp = platformQueue.Dequeue();
                Destroy(temp);

            }

        }

    }

}
