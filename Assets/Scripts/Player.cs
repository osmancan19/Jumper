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
    private float time = 0.0f;
    Rigidbody2D rb;
    int deneme;
    private GameObject tempp;
    

	float movement = 0f;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody2D>();
        deneme = 0;

	}
	
	// Update is called once per frame
	void Update () {
         
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        
    }

	void FixedUpdate()
	{
        //time = 0.0f;
        Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {

            nextFire = Time.time + fireRate;


            tempp=Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Destroy(tempp, 0.8f);

            // while (time < 2.0f)
            //{
            //shot.GetComponent<Transform>().position = new Vector2(0, deneme);
            // time += Time.deltaTime;
            //   deneme++;
            // }
        }
	}
    void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Platform" || collision.tag == "Boundary")
        {
           // anm.SetBool("isJump", true);
        }

        if (explosion != null)
        {
            Instantiate(explosion, transform.position, transform.rotation);
        }

        if (collision.tag == "Enemy")
        {
            Instantiate(playerExplosion, collision.transform.position, collision.transform.rotation);
        }
        
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }




}
