using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class RotateByAction : ActionBase
{
    public Vector3 Increment;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        if (IsLocal) {
            Tween.LocalRotation(transform, transform.localEulerAngles, transform.localEulerAngles + Increment, Duration, Delay, AnimationCurve, LoopType);
        } else {
            Tween.Rotation(transform, transform.eulerAngles, transform.eulerAngles + Increment, Duration, Delay, AnimationCurve, LoopType);
        }
    }
}
