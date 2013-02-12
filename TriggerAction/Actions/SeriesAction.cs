using UnityEngine;
using System.Collections;

public class SeriesAction : ActionBase {
  public ActionBase[] actions;

  public override void Act() {
    foreach (ActionBase action in actions) {
      action.Act();
    }
  }
}
