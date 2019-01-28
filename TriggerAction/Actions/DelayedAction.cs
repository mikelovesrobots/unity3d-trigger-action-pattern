using UnityEngine;
using System.Collections;

public class DelayedAction : ActionBase {
    public float Delay = 1f;
    public ActionBase Action;

    public override void Act() {
        StartCoroutine(DelayAction());
    }

    IEnumerator DelayAction() {
        yield return new WaitForSeconds(Delay);
        Action.Act();
    }
}
