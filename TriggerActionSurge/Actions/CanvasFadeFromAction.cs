using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class CanvasFadeFromAction : ActionBase
{
    public CanvasGroup Target;
    [Range(0,1)]
    public float Alpha;
    public float Delay = 0f;
    public float Duration = 1f;
    public AnimationCurve AnimationCurve = Tween.EaseInOutStrong;
    public Tween.LoopType LoopType;

    public override void Act()
    {
        Tween.CanvasGroupAlpha(Target, Alpha, Target.alpha, Duration, Delay, AnimationCurve, LoopType);
    }
}
