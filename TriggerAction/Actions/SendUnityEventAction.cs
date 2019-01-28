using UnityEngine;
using UnityEngine.Events;

public class SendUnityEventAction : ActionBase {
    public UnityEvent OnAct;

    public override void Act() {
        OnAct.Invoke();
    }
}
