using UnityEngine;
using System.Collections;

public class UpdateTrigger : MonoBehaviour {
    public ActionBase Action;

    private void Update() {
        Action.Act();
    }
}
