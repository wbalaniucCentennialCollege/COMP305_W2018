using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    // Public variables
    public float maxSpeed = 10.0f;

    // Private variables
    private Rigidbody2D rBody;
    private SpriteRenderer sRend;
    private Animator animator;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
        sRend = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();
	}
	
	// Used for physics calculations
	void FixedUpdate () {
        float moveHoriz = Input.GetAxis("Horizontal");

        // Pass horizontal velocity to animator (SPEED)
        animator.SetFloat("Speed", Mathf.Abs(moveHoriz));

        // Debug.Log("Move Horizontal: " + moveHoriz);
        rBody.velocity = new Vector2(moveHoriz * maxSpeed, rBody.velocity.y);

        if(moveHoriz > 0)
        {
            sRend.flipX = false;
        } else if (moveHoriz < 0)
        {
            sRend.flipX = true;
        }
	}
}
