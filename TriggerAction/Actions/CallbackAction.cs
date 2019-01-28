using UnityEngine;
using System;
using System.Collections;

public class CallbackAction : ActionBase {
    private Action callback;

    public void Initialize(Action callback) {
        this.callback = callback;
    }

    public override void Act() {
        callback();
    }
}
