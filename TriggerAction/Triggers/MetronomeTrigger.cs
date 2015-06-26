using UnityEngine;
using System.Collections;

public class MetronomeTrigger : MonoBehaviour {
  public float StartingDelay = 0.5f;
  public float TickDelay = 0.5f;
  public ActionBase Action;

  void Start () {
    StartCoroutine(DelayThenStart());
  }

  IEnumerator DelayThenStart() {
    yield return new WaitForSeconds(StartingDelay);
    StartCoroutine(DelayThenTick());
  }


  IEnumerator DelayThenTick() {
    yield return new WaitForSeconds(TickDelay);
    Action.Act();
    StartCoroutine(DelayThenTick());
  }
}
