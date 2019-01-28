using UnityEngine;
using System.Collections;

public class DebugAction : ActionBase {
    public override void Act() {
        Debug.Log("Action is firing on " + gameObject);
    }
}
