using UnityEngine;
using System.Collections;

public class PlaySoundAction : ActionBase {
    public AudioSource AudioSource;

    public override void Act() {
        AudioSource.Play();
    }
}
