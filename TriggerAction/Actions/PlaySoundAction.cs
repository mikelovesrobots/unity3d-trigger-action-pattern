using UnityEngine;
using System.Collections;

public class PlaySoundAction : ActionBase {
  public override void Act() {
    GetComponent<AudioSource>().Play();
  }
}
