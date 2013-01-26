using UnityEngine;
using System.Collections;

public class UnlockCursorAction : ActionBase {
  public override void Action() {
    Screen.lockCursor = false;
  }
}
