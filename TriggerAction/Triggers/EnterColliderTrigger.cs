using UnityEngine;
using System.Collections;

public class EnterColliderTrigger : TriggerBase {
  void OnTriggerEnter(Collider other) {
    Trigger();
  }
}
