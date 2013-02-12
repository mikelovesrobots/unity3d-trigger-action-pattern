using UnityEngine;
using System.Collections;

public class LockCursorAction : ActionBase {
  public override void Act() {
    Screen.lockCursor = true;
  }
}
