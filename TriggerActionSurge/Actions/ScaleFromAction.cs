using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ScaleFromAction : ActionBase
{
    public Vector3 Scale;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        var targetScale = transform.localScale;
        transform.localScale = Scale;
        Tween.LocalScale(transform, targetScale, Duration, Delay, AnimationCurve, LoopType);
    }
}
