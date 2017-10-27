using UnityEngine;
using System.Collections;

public class WheelsAnimation : MonoBehaviour {

    void Start () {
        iTween.RotateBy(gameObject, iTween.Hash("x", 1, "loopType", "loop", "time", 0.2));
    }
}
