using UnityEngine;
using System.Collections;

public class HitPauseAction : ActionBase {
    public int FramesToPause = 5;
    private int pauseDt;

    public override void Act() {
        Time.timeScale = 0.0f;
        pauseDt = FramesToPause;
    }

    void Update() {
        pauseDt--;
        if (pauseDt == 0) {
            Time.timeScale = 1.0f;
        }
    }
}
