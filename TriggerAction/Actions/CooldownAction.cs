using UnityEngine;
using System.Collections;

public class CooldownAction : ActionBase {
    public float CooldownDelay;
    public ActionBase Action;
    public bool InCooldown = false;

    public override void Act() {
        if (!InCooldown) {
            Action.Act();
            InCooldown = true;
            StartCoroutine(ClearCooldown());
        }
    }

    IEnumerator ClearCooldown() {
        yield return new WaitForSeconds(CooldownDelay);
        InCooldown = false;
    }
}
