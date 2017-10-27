using UnityEngine;
using System.Collections;

public class CarCrashHandler : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        GameOver.IsGameOver = true;
    }
}
