using UnityEngine;
using System.Collections;

public class DelayedAction : ActionBase {
    public float delay = 1f;
    public ActionBase target;
    [HideInInspector]
    public bool IsActionPending;

    public override void Act() {
        StartCoroutine(DelayAction());
    }

    IEnumerator DelayAction() {
        IsActionPending = true;
        yield return new WaitForSeconds(delay);
        IsActionPending = false;
        target.Act();
    }

    public void EndEarly() {
        if (IsActionPending) {
            StopAllCoroutines();
            IsActionPending = false;
            target.Act();
        }
    }
}
