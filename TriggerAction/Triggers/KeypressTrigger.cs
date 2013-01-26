using UnityEngine;
using System.Collections;

public class KeypressTrigger : TriggerBase {
  public string button;

  void Update () {
    if (Input.GetButtonDown(button)) {
      Trigger();
    }
  }
}
