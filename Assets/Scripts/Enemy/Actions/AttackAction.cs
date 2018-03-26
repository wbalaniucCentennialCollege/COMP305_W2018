using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/Actions/Attack")]
public class AttackAction : Action
{
    public override void Act(EnemyStateController controller)
    {
        Attack(controller);
    }

    private void Attack(EnemyStateController controller)
    {
        // Call attack on the zombie
        controller.enemyAttack.Attack();
    }
}
