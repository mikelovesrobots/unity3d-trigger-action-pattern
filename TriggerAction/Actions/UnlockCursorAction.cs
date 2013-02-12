using UnityEngine;
using System.Collections;

public class UnlockCursorAction : ActionBase {
  public override void Act() {
    Screen.lockCursor = false;
  }
}
