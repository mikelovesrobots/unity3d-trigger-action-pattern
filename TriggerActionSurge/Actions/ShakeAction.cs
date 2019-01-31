using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ShakeAction : ActionBase
{
    public Vector3 Intensity = Vector3.one / 4;
    public float Delay = 0f;
    public float Duration = 1f;
    public Tween.LoopType LoopType;

    public override void Act() {
        Tween.Shake(transform, transform.localPosition, Intensity, Duration, Delay, LoopType);
    }
}
