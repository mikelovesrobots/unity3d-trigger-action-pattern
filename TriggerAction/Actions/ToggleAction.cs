using UnityEngine;
using System.Collections;

public class ToggleAction : ActionBase {
  public bool toggle = false;
  public ActionBase enableAction;
  public ActionBase disableAction;

  public override void Act() {
    toggle = !toggle;
    if (toggle) {
      enableAction.Act();
    } else {
      disableAction.Act();
    }
  }
}
