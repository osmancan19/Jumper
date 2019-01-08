using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawner : MonoBehaviour
{
    // Hem BlackHole Hem Monsterlari spawnlayan script.



    public Transform player;

    private float spawnPositionY;//exposition

    public GameObject blackHolePrefab;
    public GameObject monsterPrefab;

    public float levelWidth = 3f;
    Vector3 spawnPosition = new Vector3();

    private float spawnTime;
    private float currentTime;


    private void Start()
    {
        spawnTime = Random.Range(5, 15);
        currentTime = 0f;
        //random bir sayi al bu sayi saniyeye cevrilecek ve o kadar sure sonra metor spawnlanacak.
    }

    private void Update()
    {

        currentTime += Time.deltaTime;

        if (currentTime > spawnTime)
        {

            spawnPositionY = player.position.y + 7f;

            spawnPosition.y = spawnPositionY;
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(blackHolePrefab, spawnPosition, Quaternion.identity);

            spawnTime = Random.Range(3, 15);
            currentTime = 0f;

        }

    }

}
