using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    //yaratiklarin hareketleri ve yok olus surelerini ayarlayan script.

    public GameObject gO;
    public Transform blackHole;
    public Transform player;

    private void Start()
    {
        player = FindObjectOfType<Player>().transform;
        blackHole = this.gameObject.transform;
        gO = this.gameObject;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "LaserTag")
        {

            Destroy(gO);

        }
    }

    /*
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "LaserTag")
        {

            Destroy(gO);

        }
    } */

    private void FixedUpdate()
    {

        transform.Translate(0, -(Time.deltaTime * 0.3f), 0);

        transform.Rotate(0, 0, 50f * Time.deltaTime, Space.World);

        if (player.position.y - blackHole.position.y >= 10f)
        {

            Destroy(gO);

        }

        

    }

}
