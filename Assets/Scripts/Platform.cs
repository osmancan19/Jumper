using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour {

	public float jumpForce = 10f;


    public Animator animator;
    public Animation anim;
    

    // private bool flag = false;
    //  private float time = 0.0f;


    private void Start()
    {
        
    }


    void Update()
    {

        /*
        time += Time.deltaTime;

        if (time >= 0.3f &&  flag == true)
        {
            animator.SetBool("isJump", false);

            time = 0f;

            flag = false;
        } */


    }

    /*
    private void jumpAnimationEnd()
    {
        if(animator.GetBool("isJump") == true) { 
          animator.SetBool("isJump", false);
          
        }
    }*/

    void OnCollisionEnter2D(Collision2D collision)
	{ 
        if (collision.relativeVelocity.y <= 0f)
		{


            GetComponent<AudioSource>().Play();
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
			if (rb != null)
			{

                //CancelInvoke();

                Vector2 velocity = rb.velocity;
				velocity.y = jumpForce;
                rb.velocity = velocity;

                 animator.SetBool("isJump", true);



                // flag = true;

                //anim.Play("character_jump2");

                //  animator.Play("")

                //anim.Play("character_jump");

                //animator.SetBool("isJump", false);

                // InvokeRepeating("jumpAnimationEnd",0.5f,5f);



            }


        }


	}


    public void animationEnded()
    {

        animator.SetBool("isJump", false);

    }


}
