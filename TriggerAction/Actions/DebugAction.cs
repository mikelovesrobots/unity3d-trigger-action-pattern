using UnityEngine;
using System.Collections;

public class DebugAction : ActionBase {
  public override void Action() {
    Debug.Log("Action is firing on " + gameObject);
  }
}
