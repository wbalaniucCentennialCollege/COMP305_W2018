using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementController : MonoBehaviour {

    private Animator animator;
    private Vector3 lastPosition;
    private bool isRight = true;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        lastPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        Vector2 velocity = lastPosition - transform.position;

        Debug.Log(velocity.x);

        if(velocity.x > 0 && isRight)
        {
            Flip();
        }
        else if(velocity.x < 0 && !isRight) 
        {
            Flip();
        }

        animator.SetFloat("Speed", Mathf.Abs(velocity.x));

        lastPosition = transform.position;
	}

    private void Flip()
    {
        isRight = !isRight;

        Vector3 temp = transform.localScale;
        temp.x *= -1;
        transform.localScale = temp;
    }
}
