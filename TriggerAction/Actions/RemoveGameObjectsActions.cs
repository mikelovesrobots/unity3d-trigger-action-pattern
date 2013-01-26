using UnityEngine;
using System.Collections;

public class RemoveGameObjectsActions : ActionBase {
  public GameObject[] gameObjects;

  public override void Action() {
    foreach (GameObject gameObject in gameObjects) {
      Destroy(gameObject);
    }
  }
}
