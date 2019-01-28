using UnityEngine;
using System.Collections;

public class KeypressTrigger : MonoBehaviour {
    public ActionBase Action;
    public string button;

    void Update () {
        if (Input.GetButtonDown(button)) {
            Action.Act();
        }
    }
}
