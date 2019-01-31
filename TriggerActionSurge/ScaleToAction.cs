using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ScaleToAction : ActionBase
{
    public Vector3 Scale;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act() {
        Tween.LocalScale(transform, Scale, Duration, Delay, AnimationCurve, LoopType);
    }
}
