using UnityEngine;
using System.Collections;

public class OnceAction : ActionBase {
  public ActionBase action;
  private bool used = false;

  public override void Act () {
    if (!used) {
      used = true;
      action.Act();
    }
  }
}
