using UnityEngine;
using System.Collections;

public class TriggerEnterTrigger : TriggerBase {
  private void OnTriggerEnter(Collider other) {
    Trigger();
  }
}
