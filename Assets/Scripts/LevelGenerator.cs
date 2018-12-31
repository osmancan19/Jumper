using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour {

    private Queue<GameObject> platformQueue;
    public GameObject firstPlatform;
    public GameObject platformPrefab;
    private GameObject temp;
    public int numberOfPlatforms = 120;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 1.5f;
    Vector3 spawnPosition = new Vector3();
    private float time = 0.0f;
    // Use this for initialization
    void Start () {
        platformQueue = new Queue<GameObject>();

        spawnPosition.y = -3;
        spawnPosition.x = Random.Range(-levelWidth, levelWidth);
        temp = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
        platformQueue.Enqueue(temp);

        for (int i = 0; i < numberOfPlatforms; i++)
        {
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            temp = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platformQueue.Enqueue(temp);
        }
	}
    void Update()
    {
        time += Time.deltaTime;
        
        if (time > 5.0f)  
        {
            
            if (firstPlatform != null)
            {
                Destroy(firstPlatform);
            }
            temp = platformQueue.Dequeue();
            Destroy(temp);
            spawnPosition.y += Random.Range(minY, maxY);
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);
            temp = Instantiate(platformPrefab, spawnPosition, Quaternion.identity);
            platformQueue.Enqueue(temp);

            time = 3.7f;

        }
        

    }

}
