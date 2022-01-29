using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheckAlternate : MonoBehaviour
{
    public float speed;
    public float jumpSpeed;
    public bool isJump;

    private float forceX;
    private float forceY;
    private Vector2 maxVelocity;

    public Animator myAnimator;
    public Rigidbody2D myRigidbody;

    private void Start()
    {
        myAnimator = GetComponent<Animator>();
        myRigidbody = GetComponent<Rigidbody2D>();
        isJump = false;
    }

    private void Update()
    {
        forceX = 0f;
        forceY = 0f;
        var absVelX = Mathf.Abs(myRigidbody.velocity.x);

        if (true)
        {

        }
    }
}
