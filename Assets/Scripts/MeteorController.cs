using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorController : MonoBehaviour
{

    //spawnlanan meteorda kullandigimiz scriptimiz.
    //meteorun hareket hizi vede yonunu ayni zamanda yokolus suresini ayarliyoruz.

    private float meteorSpeed = 5f;
    public GameObject gO;
    public Transform meteor;
    public Transform player;

    private void Start()
    {
        player= FindObjectOfType<Player>().transform;
        meteor = this.gameObject.transform;
        gO = this.gameObject;
    }

    private void FixedUpdate()
    {
        
        transform.Translate(0, -(Time.deltaTime * meteorSpeed), 0);
      
        if(player.position.y - meteor.position.y >= 10f)
        {

            Destroy(gO);

        } 

        //transform.Rotate(0, 0, 50f * Time.deltaTime, Space.World);

    }



}
