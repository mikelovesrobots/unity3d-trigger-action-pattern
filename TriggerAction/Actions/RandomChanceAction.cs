using UnityEngine;
using System.Collections;

public class RandomChanceAction : ActionBase {
  public int percentageChance;
  public ActionBase action;

  public override void Action() {
    if (Random.Range(0, 100) < percentageChance) {
      action.Action();
    }
  }
}
