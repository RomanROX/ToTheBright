using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    public float jump;
    public float horizontal;


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
        horizontal = Input.GetAxisRaw("Horizontal");
        jump = Input.GetAxisRaw("Jump");

        if (Input.GetKey(KeyCode.D))
        {
            anim.SetInteger("AnimState", 1);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            anim.SetInteger("AnimState", 2);
        }

        else
        {
            anim.SetInteger("AnimState", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpAmount, ForceMode2D.Impulse);
            anim.SetBool("isJumping", true);
        }

        if (rb.velocity.y >= 0)
        {
            rb.gravityScale = gravityScale;
        }
        else if (rb.velocity.y < 0)
        {
            rb.gravityScale = fallingGravityScale;
        }
    }

    
    private void FixedUpdate()
    {
        Move();
    }

    public void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    
    

}
