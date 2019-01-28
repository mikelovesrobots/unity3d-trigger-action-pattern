using UnityEngine;
using System.Collections;

public class SpawnPrefabAction : ActionBase {
  public GameObject Prefab;
  public bool AttachToSelf = false;

  public bool IsTemporary;
  public float TemporaryLifespan;

  public override void Act() {
    var instance = GameObject.Instantiate(Prefab, transform.position, transform.rotation) as GameObject;

    if (IsTemporary) {
      GameObject.Destroy(instance, TemporaryLifespan);
    }

    if (AttachToSelf) {
      instance.transform.parent = transform;
    }
  }
}
