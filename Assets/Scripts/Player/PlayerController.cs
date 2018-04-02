using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    /*
    public float maxSpeed = 10;
    public float jumpForce = 700f;
    public float groundRadius = 0.2f;
    public Transform groundCheck;
    public LayerMask defineGround;
    */

    public PlayerStats stats;

    private Rigidbody2D rBody;
    private Animator animator;

    private float moveH;
    private float distToGround;
    private bool isRight = true;
    private bool isGrounded = false;

    // Use this for initialization
    void Start () {
        rBody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        distToGround = GetComponent<Collider2D>().bounds.extents.y;
        // stats.groundCheck = transform.Find("GroundCheck").transform;
	}
	
	// Update is called once per frame
	void Update () {
		if(isGrounded && Input.GetAxis("Jump") > 0)
        {
            animator.SetBool("Ground", false);
            rBody.AddForce(new Vector2(0, stats.jumpForce));
            isGrounded = false;
        }
	}

    // Do not need to use Time.deltaTime()
    void FixedUpdate()
    {
        // Checks whether character is grounded
        // isGrounded = Physics2D.OverlapCircle(stats.groundCheck.position, stats.groundRadius, stats.defineGround);
        isGrounded = CheckIsGround();
        animator.SetBool("Ground", isGrounded);

        // Debug.Log("Grounded? " + isGrounded);

        // Pass vertical velocity to animator
        animator.SetFloat("vSpeed", rBody.velocity.y);

        // Read input
        moveH = Input.GetAxis("Horizontal");

        // Set speed variable in animator
        animator.SetFloat("Speed", Mathf.Abs(moveH));

        // Set character velocity
        rBody.velocity = new Vector2(moveH * stats.walkSpeed, rBody.velocity.y);

        // Check direction and flip sprite
        if (rBody.velocity.x > 0 && !isRight)
        {
            Flip();
        }
        else if (rBody.velocity.x < 0 && isRight)
        { 
            Flip();
        }
    }

    private void Flip()
    {
        isRight = !isRight;

        Vector3 temp = transform.localScale;
        temp.x *= -1;
        transform.localScale = temp;
    }

    private bool CheckIsGround()
    {
        return Physics2D.Raycast(
            transform.position, 
            -Vector3.up, 
            distToGround + stats.groundCheckOffset, // The "0.1f" will be replaced by a call to playerstats
            stats.defineGround);
    }
}
