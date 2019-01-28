using UnityEngine;
using System.Collections;

public class RemoveGameObjectsAction : ActionBase {
    public GameObject[] GameObjects;

    public override void Act() {
        foreach (var gameObject in GameObjects) {
            Destroy(gameObject);
        }
    }
}
