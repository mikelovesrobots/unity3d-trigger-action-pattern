using UnityEngine;
using System.Collections;

public class ToggleAction : ActionBase {
  public bool toggle = false;

  public override void Action() {
    toggle = !toggle;
    if (toggle) {
      OnToggleEnable();
    } else {
      OnToggleDisable();
    }
  }

  public virtual void OnToggleEnable() {

  }

  public virtual void OnToggleDisable() {

  }
}
