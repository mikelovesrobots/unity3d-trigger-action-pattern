using UnityEngine;
using System.Collections;

public class OnceAction : ActionBase {
    public ActionBase Action;
    private bool used = false;

    public override void Act() {
        if (!used) {
            used = true;
            Action.Act();
        }
    }
}
