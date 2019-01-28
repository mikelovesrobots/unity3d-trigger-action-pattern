using UnityEngine;
using System.Collections;

public class SeriesAction : ActionBase {
    public ActionBase[] Actions;

    public override void Act() {
        foreach (var action in Actions) {
            action.Act();
        }
    }
}
