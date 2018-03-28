using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerAttackSound
{
    public AudioClip swordSwing1;
    public AudioClip swordSwing2;
    public AudioClip swordSwing3;
}

public class PlayerAttack : MonoBehaviour {

    public float weaponDamage = 5.0f;
    public Transform attackCheck;
    public float attackCheckRadius = 0.2f;
    public LayerMask defineAttack;
    public PlayerAttackSound attackSound;

    private Animator animator;
    private bool isAttacking = false;
    private Collider2D col2D;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetAxis("Fire1") > 0 && !isAttacking)
        {
            // Play attack sound
            audioSource.clip = attackSound.swordSwing1;
            audioSource.Play();

            isAttacking = true;
            animator.SetTrigger("Attack");

            col2D = Physics2D.OverlapCircle(attackCheck.position, attackCheckRadius, defineAttack);

            if(col2D != null && col2D.tag == "Enemy")
            {
                Debug.Log("Enemy hit");
                // Do some damage to the enemy.
                col2D.GetComponent<EnemyHealth>().Damage(weaponDamage);
            }
        }
	}
    
    public void ResetAttackBool()
    {
        isAttacking = false;
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(attackCheck.position, attackCheckRadius);
    }
}
