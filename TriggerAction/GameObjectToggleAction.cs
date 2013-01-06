using UnityEngine;
using System.Collections;

public class GameObjectToggleAction : ToggleAction {
  public GameObject target;

  public override void OnToggleEnable() {
    target.SetActive(true);
  }

  public override void OnToggleDisable() {
    target.SetActive(false);
  }
}
