using UnityEngine;
using System.Collections;

public class EndDelayedActionEarlyAction : ActionBase {
    public DelayedAction DelayedAction;

    public override void Act() {
        DelayedAction.EndEarly();
    }
}
