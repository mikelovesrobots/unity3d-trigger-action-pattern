using UnityEngine;
using System.Collections;

public class RemoveGameObjectAction : ActionBase {
    public GameObject GameObject;

    public override void Act() {
        Destroy(gameObject);
    }
}
