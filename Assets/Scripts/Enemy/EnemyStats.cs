using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/EnemyStats")]
public class EnemyStats : ScriptableObject {
    public float moveSpeed = 1.0f;
    public float lookRange = 10.0f;

    public float patrolSpeed = 0.5f;
    public float chaseSpeed = 1.0f;

    public float attackRange = 0.1f;
    public float attackRate = 1.0f;
    public float attackDamage = 5f;
}
