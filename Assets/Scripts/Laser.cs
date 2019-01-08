using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    private GameObject destroyThatShit;
    // Start is called before the first frame update
    void Start()
    {

        //transform.Translate(0, Time.deltaTime * 10f , 0);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(0, Time.deltaTime * 10f , 0);

    }

    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.relativeVelocity.y <= 0f && collision.collider.tag == "BlackHole")
        {


            destroyThatShit = collision.collider.gameObject;

            if (destroyThatShit != null)
            {

                Destroy(destroyThatShit);

            }

        }

    } */

}
