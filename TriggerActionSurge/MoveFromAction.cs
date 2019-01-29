using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class MoveFromAction : ActionBase
{
    public Vector3 Position;
    public bool IsLocal = true;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        if (IsLocal) {
            Tween.LocalPosition(transform, Position, transform.localPosition, Duration, Delay, AnimationCurve, LoopType);
        } else {
            Tween.Position(transform, Position, transform.position, Duration, Delay, AnimationCurve, LoopType);
        }
    }
}
