using UnityEngine;
using System.Collections;

public class KeypressTrigger : MonoBehaviour {
    public ActionBase Action;
    public string ButtonName = "Fire1";

    void Update () {
        if (Input.GetButtonDown(ButtonName)) {
            Action.Act();
        }
    }
}
