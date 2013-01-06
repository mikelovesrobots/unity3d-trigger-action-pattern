using UnityEngine;
using System.Collections;

[RequireComponent (typeof(ActionBase))]
public class KeypressTrigger : MonoBehaviour {
  public string button;
  private ActionBase action;

  void Start () {
    action = GetComponent<ActionBase>();
  }

  void Update () {
    if (Input.GetButtonDown(button)) {
      action.Action();
    }
  }
}
