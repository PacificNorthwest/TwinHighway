using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {

    public static float speed = -25;

    void Start()
    {
       Application.targetFrameRate = 60;
		GameOver.IsPaused = false;
		GameOver.IsGameOver = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (GameOver.IsGameOver == false && GameOver.IsPaused == false)
        {
            if (Score.score > 10)
                speed = -28;
            if (Score.score > 20)
                speed = -33;
            if (Score.score > 30)
                speed = -36;
            if (Score.score > 40)
                speed = -40;
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }
    }
}
