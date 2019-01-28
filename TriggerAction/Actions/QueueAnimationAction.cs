using UnityEngine;
using System.Collections;

public class QueueAnimationAction : ActionBase {
    public Animation Animation;
    public string AnimationName;

    public override void Act() {
        Animation.CrossFadeQueued(AnimationName);
    }
}
