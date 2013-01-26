using UnityEngine;
using System.Collections;

public class SetActiveAction : ActionBase {
  public GameObject target;
  public bool isActive;

  public override void Action() {
    target.SetActive(isActive);
  }
}
