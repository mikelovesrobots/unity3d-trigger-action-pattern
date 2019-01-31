using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ScaleByAction : ActionBase
{
    public float Increment = 2f;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        Tween.LocalScale(transform, transform.localScale * Increment, Duration, Delay, AnimationCurve, LoopType);
    }
}
