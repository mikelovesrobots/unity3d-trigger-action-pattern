using UnityEngine;
using System.Collections;

public class ShiftSplitterAction : ActionBase {
    public ActionBase ShiftAction;
    public ActionBase StandardAction;

    public override void Act() {
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) {
            ShiftAction.Act();
        } else {
            StandardAction.Act();
        }
    }
}
