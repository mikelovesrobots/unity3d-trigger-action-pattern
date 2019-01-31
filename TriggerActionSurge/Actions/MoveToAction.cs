using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class MoveToAction : ActionBase
{
    public Vector3 Position;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        if (IsLocal) {
            Tween.LocalPosition(transform, transform.localPosition, Position, Duration, Delay, AnimationCurve, LoopType);
        } else {
            Tween.Position(transform, transform.position, Position, Duration, Delay, AnimationCurve, LoopType);
        }
    }
}
