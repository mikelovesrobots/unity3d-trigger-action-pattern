using UnityEngine;
using System.Collections;

public class SetActiveAction : ActionBase {
  public GameObject target;
  public bool setToActive;

  public override void Act() {
    target.SetActive(setToActive);
  }
}
