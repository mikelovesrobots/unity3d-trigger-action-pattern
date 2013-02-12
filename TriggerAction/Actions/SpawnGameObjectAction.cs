using UnityEngine;
using System.Collections;

public class SpawnGameObjectAction : ActionBase {
  public GameObject prefab;
  public bool attachToSelf = false;

  public bool isTemporary;
  public float lifespan;

  public override void Act() {
    GameObject instance = GameObject.Instantiate(prefab, transform.position, transform.rotation) as GameObject;

    if (isTemporary) {
      GameObject.Destroy(instance, lifespan);
    }

    if (attachToSelf) {
      instance.transform.parent = transform;
    }
  }
}
