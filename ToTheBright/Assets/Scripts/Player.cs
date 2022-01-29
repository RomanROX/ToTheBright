using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    public float horizontal;

    public bool jumpdet = true;
    public bool IsRight = true;


    public float jumpAmount = 35;
    public float gravityScale = 10;
    public float fallingGravityScale = 40;


    public Rigidbody2D rb;
    public Animator anim;


    



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        BlendTree();

        horizontal = Input.GetAxisRaw("Horizontal");
        jump = Input.GetAxisRaw("Jump");

        

        if (Input.GetKeyDown(KeyCode.Space) && jumpdet==true)
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
            jumpdet = false;
        }

        //if (rb.velocity.y >= 0)
        //{
        //    rb.gravityScale = gravityScale;
        //}
        //else if (rb.velocity.y < 0)
        //{
        //    rb.gravityScale = fallingGravityScale;
        //}

        if (rb.velocity.y==0)
        {
            anim.SetBool("isJumping", false);
        }

        if (rb.velocity.x > 0)
        {
            anim.SetBool("isRight", true);
        }
        else if (rb.velocity.x < 0)
        {
            anim.SetBool("isRight", false);
        }


        if (Input.anyKey)
        {
            anim.SetBool("isIdle", false);
        }
        else { anim.SetBool("isIdle", true); anim.SetBool("isJumping", false); }

        anim.SetFloat("moveY", jump);

        //if (horizontal > 0)
        //{
        //    anim.SetBool("isRight", true);
        //}
        //else if (horizontal < 0) { anim.SetBool("isRight", false); }

        //if (jump!=0)
        //{
        //    anim.SetBool("isJumping", true);
        //}else { anim.SetBool("isJumping", false); }


    }

    
    private void FixedUpdate()
    {
        Move();
        anim.SetBool("Grounded", jumpdet);
        anim.SetFloat("vSpeed", rb.velocity.y);
    }

    public void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            jumpdet = true;
        }
    }

    public void BlendTree()
    {
        if (Input.GetKey(KeyCode.D))
        {
            anim.SetInteger("Move", 1);
            anim.SetFloat("WalkBT", 0);
            IsRight = true;
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("Move", 1);
            anim.SetFloat("WalkBT", 2);
            IsRight = false;
        }

        else
        {
            anim.SetInteger("Move", 0);
            if (IsRight==true)
            {
                anim.SetFloat("IdleBT", 0);
            }
            else
            {
                anim.SetFloat("IdleBT", 2);
            }
        }
    }


}
