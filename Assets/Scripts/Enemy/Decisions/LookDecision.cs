using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Decisions/Look")]
public class LookDecision : Decision {
    public override bool Decide(EnemyStateController controller)
    {
        return Look(controller);
    }

    private bool Look(EnemyStateController controller)
    {
        // Look through our eyes
        RaycastHit2D hit = Physics2D.Raycast(
            controller.eyes.position, 
            controller.eyes.TransformDirection(Vector3.right),
            controller.enemyStats.lookRange,
            controller.playerLayer);

        Debug.DrawRay(
            controller.eyes.position, 
            controller.eyes.TransformDirection(Vector3.right) * controller.enemyStats.lookRange, 
            Color.green);

        // Check if we hit something
        // Check if we hit the player
        if(hit && hit.collider.CompareTag("Player"))
        {
            // Set my chase target to the player
            return true;
        }
        else
        {
            return false;
        }

        
    }
}
