using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;

    public Rigidbody2D rb;


    public Animator animator;
    public Animation anim;


    void OnCollisionEnter2D(Collision2D collision)
	{

        if (collision.relativeVelocity.y <= 0f  && collision.collider.tag == "PlayerTag") 
		{

            GetComponent<AudioSource>().Play();
            rb = collision.collider.GetComponent<Rigidbody2D>();

			if (rb != null)
			{
               
                Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
                rb.velocity = velocity;

            }

        }

        
    }

}
