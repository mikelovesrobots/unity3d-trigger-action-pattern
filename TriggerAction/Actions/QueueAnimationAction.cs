using UnityEngine;
using System.Collections;

public class QueueAnimationAction : ActionBase {
  public GameObject target;
  public string animationName;

  public override void Act() {
    target.GetComponent<Animation>().CrossFadeQueued(animationName);
  }
}
