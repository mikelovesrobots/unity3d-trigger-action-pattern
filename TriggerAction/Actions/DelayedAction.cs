using UnityEngine;
using System.Collections;

public class DelayedAction : ActionBase {
  public float delay = 1f;
  public ActionBase target;

  public override void Act() {
    StartCoroutine(DelayAction());
  }

  IEnumerator DelayAction() {
    yield return new WaitForSeconds(delay);
    target.Act();
  }
}
