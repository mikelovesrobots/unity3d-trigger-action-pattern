using UnityEngine;
using System.Collections;

public class ToggleAction : ActionBase {
    public bool Toggled = false;
    public ActionBase EnabledAction;
    public ActionBase DisabledAction;

    public override void Act() {
        Toggled = !Toggled;
        if (Toggled) {
            EnabledAction.Act();
        } else {
            DisabledAction.Act();
        }
    }
}
