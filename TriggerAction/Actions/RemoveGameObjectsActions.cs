using UnityEngine;
using System.Collections;

public class RemoveGameObjectsActions : ActionBase {
  public GameObject[] gameObjects;

  public override void Act() {
    foreach (GameObject gameObject in gameObjects) {
      Destroy(gameObject);
    }
  }
}
