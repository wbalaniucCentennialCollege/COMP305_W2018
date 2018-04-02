using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
[System.Serializable]
public class PlayerAttackSound
{
    public AudioClip swordSwing1;
    public AudioClip swordSwing2;
    public AudioClip swordSwing3;
}
*/

public class PlayerAttack : MonoBehaviour {

    /*
    public float weaponDamage = 5.0f;
    public Transform attackCheck;
    public float attackCheckRadius = 0.2f;
    public LayerMask defineAttack;
    public PlayerAttackSound attackSound;
    */

    public PlayerStats stats;

    private Animator animator;
    private Collider2D col2D;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();

        stats.attackCheck = transform.Find("AttackCheck").transform;
	}
	
	// Update is called once per frame
	void Update () {
        
		if(Input.GetAxis("Fire1") > 0 && !animator.GetBool("Attack"))
        {
            // Play attack sound
            audioSource.clip = stats.swordSwing[0];
            audioSource.Play();
            
            animator.SetTrigger("Attack");

            col2D = Physics2D.OverlapCircle(stats.attackCheck.position, stats.attackCheckRadius, stats.defineAttack);

            if(col2D != null && col2D.tag == "Enemy")
            {
                Debug.Log("Enemy hit");
                // Do some damage to the enemy.
                col2D.GetComponent<EnemyHealth>().Damage(stats.attackDamage);
            }
        }
	}
    
    public void ResetAttackBool()
    {
        animator.ResetTrigger("Attack");
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(stats.attackCheck.position, stats.attackCheckRadius);
    }
}
