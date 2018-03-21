using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu (menuName = "PluggableAI/State")]
public class State : ScriptableObject {
    public Action[] actions;
    public Transition[] transitions;

    public void UpdateState(EnemyStateController controller)
    {
        // Evaluate all actions and all transitions/decisions
        DoActions(controller);
        CheckTransitions(controller);
    }

    private void DoActions(EnemyStateController controller)
    {
        for (int i = 0; i < actions.Length; i++)
        {
            actions[i].Act(controller);
        }
    }

    private void CheckTransitions(EnemyStateController controller)
    {

    }
}
