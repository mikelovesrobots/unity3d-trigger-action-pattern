using UnityEngine;
using System.Collections;

public class ActionBase : MonoBehaviour {
  public virtual void Action () {
    Debug.Log("Override ActionBase#Action!");
  }
}
