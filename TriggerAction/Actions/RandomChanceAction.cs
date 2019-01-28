using UnityEngine;
using System.Collections;

public class RandomChanceAction : ActionBase {
    public int PercentageChance;
    public ActionBase Action;

    public override void Act() {
        if (Random.Range(0, 100) <= PercentageChance) {
            Action.Act();
        }
    }
}
