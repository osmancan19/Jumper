using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorGenerator : MonoBehaviour
{

    //meteoru spawnlayan script ne kadar sruede bir spawnlanacagi ayarlanabilr.

    public Transform player;

    private float spawnPositionY;//exposition

    public GameObject meteorPrefab;

    public float levelWidth = 3f;
    Vector3 spawnPosition = new Vector3();

    private float spawnTime;
    private float currentTime;

    private void Start()
    {
        spawnTime = Random.Range(2, 10);
        currentTime = 0f;
        //random bir sayi al bu sayi saniyeye cevrilecek ve o kadar sure sonra metor spawnlanacak.
    }

    private void Update()
    {

        currentTime += Time.deltaTime;

        if(currentTime > spawnTime)
        {

            spawnPositionY = player.position.y + 10f;

            spawnPosition.y = spawnPositionY;
            spawnPosition.x = Random.Range(-levelWidth, levelWidth);

            Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);

            spawnTime = Random.Range(0, 10);
            currentTime = 0f;

        }

    }


}
