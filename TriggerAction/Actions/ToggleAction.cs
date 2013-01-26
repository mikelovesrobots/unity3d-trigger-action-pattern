using UnityEngine;
using System.Collections;

public class ToggleAction : ActionBase {
  public bool toggle = false;
  public ActionBase enableAction;
  public ActionBase disableAction;

  public override void Action() {
    toggle = !toggle;
    if (toggle) {
      enableAction.Action();
    } else {
      disableAction.Action();
    }
  }
}
