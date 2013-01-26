using UnityEngine;
using System.Collections;

public class PlaySoundAction : ActionBase {
  public override void Action() {
    audio.Play();
  }
}
