using UnityEngine;
using System.Collections;

public class RepeatAction : ActionBase {
  public float DelayBetweenActions = 0.25f;
  public int Repeats = 2;
  public ActionBase target;

  public override void Act() {
    StartCoroutine(DelayAction(Repeats));
  }

  IEnumerator DelayAction(int repeatsLeft) {
    yield return new WaitForSeconds(DelayBetweenActions);
    target.Act();
    repeatsLeft--;
    if (repeatsLeft > 0) {
      StartCoroutine(DelayAction(repeatsLeft));
    }
  }
}
