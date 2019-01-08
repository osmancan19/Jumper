using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {

	public float movementSpeed = 31f;
    public Animator anm;
    public GameObject shot;
    public Transform shotSpawn;
    public float fireRate;
    private float nextFire;
    public GameObject explosion;
    public GameObject playerExplosion;
    Rigidbody2D rb;
    private GameObject tempp;
    public Animator animator;
    public Animation anim;
    public Transform currentPosition;

    private float currentpositionX;
    private float currentpositionY;


    private float score;

    float movement = 0f;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
	}
	
	void Update ()
    {

        movement = Input.GetAxis("Horizontal") * movementSpeed;


    }

	void FixedUpdate()
	{
        //karakter hareketleri yapilacak.(saga gidince sola gelmesi vb.)
        currentpositionX = currentPosition.position.x;
        currentpositionY = currentPosition.position.y;

        if (currentpositionX < -4.6f)
        {

            transform.Translate(7f, currentpositionY, 0);

        }
        else if (currentpositionX > 3.60)
        {

            transform.Translate(-7f, currentpositionY, 0);

        }


        Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            tempp=Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Destroy(tempp, 0.8f);
        }

        if(rb.position.y < -6f)
        {

            FindObjectOfType<GameManager>().EndGame();

        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.collider.tag == "platform") //eger platforma degersek karakter ziplama animasyonu calisiyor.
            animator.SetBool("isJump", true);

        if (collision.collider.tag == "Meteor") { //eger meteor carparsa end game.

            FindObjectOfType<GameManager>().EndGame();

        }


        // score = score + 0.1f;

    }

    /*
    private void OnCollisionEnter(Collision collision)
    {


        
    }

    void OnTriggerEnter(Collider collision)
    {


    } */

    public void EndEvent()
    {
        animator.SetBool("isJump", false);

    }

}
