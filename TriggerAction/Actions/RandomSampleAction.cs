using UnityEngine;
using System;
using System.Collections;

public class RandomSampleAction : ActionBase {
    public ActionBase[] Actions;

    public override void Act() {
        RandomChoiceAction.Act();
    }

    private ActionBase RandomChoiceAction => Actions[UnityEngine.Random.Range(0, Actions.Length)];
}
