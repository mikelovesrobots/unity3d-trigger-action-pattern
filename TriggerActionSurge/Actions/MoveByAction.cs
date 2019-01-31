using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class MoveByAction : ActionBase
{
    public Vector3 Increment;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        if (IsLocal) {
            Tween.LocalPosition(transform, transform.localPosition, transform.localPosition + Increment, Duration, Delay, AnimationCurve, LoopType);
        } else {
            Tween.Position(transform, transform.position, transform.position + Increment, Duration, Delay, AnimationCurve, LoopType);
        }
    }
}
