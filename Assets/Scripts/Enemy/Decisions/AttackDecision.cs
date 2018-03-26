using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/AttackDecision")]
public class AttackDecision : Decision
{
    public override bool Decide(EnemyStateController controller)
    {
        return DoAttack(controller);
    }

    private bool DoAttack(EnemyStateController controller)
    {
        // Check if an object is in front of the zombie
        RaycastHit2D hit = Physics2D.Raycast(
            controller.eyes.position,
            controller.eyes.TransformDirection(Vector2.right),
            controller.enemyStats.attackRange,
            controller.playerLayer);

        Debug.DrawRay(
            controller.eyes.position, 
            controller.eyes.TransformDirection(Vector2.right) * controller.enemyStats.attackRange, 
            Color.red);

        // Attack it
        if(hit && hit.collider.CompareTag("Player"))
        {
            //Debug.Log("I am close enough to attack the player");
            // Start attacking
            controller.chaseTarget = hit.transform; // NOT NECESSARY BUT FINE ANYWAYS
            return true;
        }
        else
        {
            return false;
        }
        
    }
}
