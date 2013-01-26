using UnityEngine;
using System;
using System.Collections;

public class TriggerBase : MonoBehaviour {
  public ActionBase action;

  protected virtual void Start () {
    if (action == null) {
      action = GetComponent<ActionBase>();
      if (action == null) {
        throw new Exception("Action wasn't assigned to " + this + " on gameObject: " + gameObject);
      }
    }
  }

  public void Trigger () {
    if (action) {
      action.Action();
    }
  }
}
