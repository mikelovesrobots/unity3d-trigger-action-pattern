using UnityEngine;
using System.Collections;

public class CooldownAction : ActionBase {
  public float cooldownDelay;
  public ActionBase action;
  public bool inCooldown = false;

  public override void Act() {
    if (!inCooldown) {
      action.Act();
      inCooldown = true;
      StartCoroutine(ClearCooldown());
    }
  }

  IEnumerator ClearCooldown() {
    yield return new WaitForSeconds(cooldownDelay);
    inCooldown = false;
  }
}
