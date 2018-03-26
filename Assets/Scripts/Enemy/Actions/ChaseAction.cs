using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action
{
    public override void Act(EnemyStateController controller)
    {
        Chase(controller);
    }

    private void Chase(EnemyStateController controller)
    {
        Vector2 walkVector = Vector2.MoveTowards(controller.transform.position, controller.chaseTarget.position, Time.fixedDeltaTime * controller.enemyStats.chaseSpeed);
        controller.transform.position = new Vector2(walkVector.x, controller.transform.position.y);
    }
}
