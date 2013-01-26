using UnityEngine;
using System.Collections;

public class LockCursorAction : ActionBase {
  public override void Action() {
    Screen.lockCursor = true;
  }
}
