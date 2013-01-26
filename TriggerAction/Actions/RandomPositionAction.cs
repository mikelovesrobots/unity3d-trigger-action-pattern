using UnityEngine;
using System.Collections;

public class RandomPositionAction : ActionBase {
  public GameObject target;
  public Vector3 positionMin = Vector3.zero;
  public Vector3 positionMax = Vector3.one;

  private void Start() {
    if (target == null) {
      target = gameObject;
    }
  }

  public override void Action() {
    float x = Random.Range(positionMin.x, positionMax.x);
    float y = Random.Range(positionMin.y, positionMax.y);
    float z = Random.Range(positionMin.z, positionMax.z);
    target.transform.localPosition = new Vector3(x, y, z);
  }
}
