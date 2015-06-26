using UnityEngine;
using System.Collections;

public class UnlockCursorAction : ActionBase {
  public override void Act() {
    Cursor.visible = true;
    Cursor.lockState = CursorLockMode.None;
  }
}
