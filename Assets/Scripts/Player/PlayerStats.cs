using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "Player/PlayerStats")]
public class PlayerStats : ScriptableObject
{
    [Header("Movement Settings")]
    public float walkSpeed = 5.0f;
    public float jumpForce = 325.0f;

    [Header("Ground Check Settings")]
    public float groundCheckOffset = 0.1f;
    // public Transform groundCheck;
    public LayerMask defineGround;
    public Color groundCheckGizmoColour = Color.yellow;

    [Header("Audio Settings")]
    public AudioClip jump;
    public AudioClip walk;
    public AudioClip death;
    public AudioClip[] swordSwing;

    [Header("Combat Settings")]
    public float attackCheckRadius = 0.4f;
    public LayerMask defineAttack;
    public Transform attackCheck;
    public float attackDamage = 5.0f;
    public Color attackGizmoColour = Color.red;
}
