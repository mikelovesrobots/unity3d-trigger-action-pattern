using UnityEngine;
using System.Collections;

public class ShiftSplitterAction : ActionBase {
  public ActionBase shiftAction;
  public ActionBase standardAction;

  public override void Act() {
    if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
      shiftAction.Act();
    } else {
      standardAction.Act();
    }
  }
}
