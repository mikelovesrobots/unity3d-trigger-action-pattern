using UnityEngine;
using System.Collections;

public class EnterColliderTrigger : TriggerBase {
  private void OnTriggerEnter(Collider other) {
    Trigger();
  }
}
