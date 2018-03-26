using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStateController : MonoBehaviour {

    public State currentState;
    public State sameState;
    public EnemyStats enemyStats;
    public Transform eyes;
    public LayerMask playerLayer;

    public List<Transform> waypoints;

    [HideInInspector] public int nextWaypoint;
    [HideInInspector] public Transform chaseTarget;
    [HideInInspector] public EnemyAttack enemyAttack;

	// Use this for initialization
	void Start () {
        enemyAttack = GetComponent<EnemyAttack>();
	}
	
	// Update is called once per frame
	void Update () {
        currentState.UpdateState(this);
	}

    public void TransitionToState(State nextState)
    {
        if(nextState != sameState)
        {
            currentState = nextState;
        }
    }
}
