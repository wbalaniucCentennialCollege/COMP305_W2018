using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Patrol")]
public class PatrolAction : Action {
    public override void Act(EnemyStateController controller)
    {
        Patrol(controller);
    }

    private void Patrol(EnemyStateController controller)
    {
        // Start moving the zombie
        Vector2 walkVector = Vector2.MoveTowards(
            controller.transform.position, 
            controller.waypoints[controller.nextWaypoint].position, 
            Time.fixedDeltaTime * controller.enemyStats.patrolSpeed);

        controller.transform.position = new Vector2(walkVector.x, controller.transform.position.y);

        // Determine distance to the target
        float distanceToWaypoint = Mathf.Abs(controller.transform.position.x - controller.waypoints[controller.nextWaypoint].position.x);

        // Change targets
        if(distanceToWaypoint < 0.2f)
        {
            controller.nextWaypoint = (controller.nextWaypoint + 1) % controller.waypoints.Count;
        }
    }
}
