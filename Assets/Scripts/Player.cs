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


    float movement = 0f;
    
	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;

    }

	void FixedUpdate()
	{

        Vector2 velocity = rb.velocity;
		velocity.x = movement;
		rb.velocity = velocity;

        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            tempp=Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
            Destroy(tempp, 0.8f);
        }

	}

    void OnCollisionEnter2D(Collision2D collision)
    {
       animator.SetBool("isJump", true);
       // animator.SetTrigger("jmp");
        //animator.ResetTrigger("idle");
    }

    void OnTriggerEnter(Collider collision)
    {


    }

    public void EndEvent()
    {
        animator.SetBool("isJump", false);
        //animator.ResetTrigger("jmp");
       // animator.SetTrigger("idle");

    }

}
