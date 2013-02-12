using UnityEngine;
using System.Collections;

public class ActionBase : MonoBehaviour {
  public virtual void Act () {
    Debug.Log("Override ActionBase#Act!");
  }
}
