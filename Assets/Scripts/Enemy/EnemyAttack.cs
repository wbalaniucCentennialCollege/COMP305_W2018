using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    private Animator animator;
    private bool isAttacking = false;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
	}
	
    public void Attack()
    {
        if(!isAttacking)
        {
            animator.SetTrigger("Attack");
            isAttacking = true;
        }
    }

    public void ResetAttack()
    {
        isAttacking = false;
    }
}
