using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOver : MonoBehaviour {

    public Text StatusText;
    public static bool IsGameOver = false;
    public static bool IsPaused = false;
	
	// Update is called once per frame
	void Update () {
        if (IsGameOver)
        {
            StatusText.text = "Game Over";
        }
	}
}
