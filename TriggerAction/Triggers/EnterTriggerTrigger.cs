using UnityEngine;
using System.Collections;

public class EnterTriggerTrigger : MonoBehaviour {
    public ActionBase Action;

    private void OnTriggerEnter(Collider other) {
        Action.Act();
    }
}
