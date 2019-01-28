using UnityEngine;
using System.Collections;

public class LockCursorAction : ActionBase {
    public override void Act() {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
