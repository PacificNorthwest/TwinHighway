using UnityEngine;
using System.Collections;

public class GameMenu : MonoBehaviour {

    public GUISkin skin;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GameOver.IsPaused = !GameOver.IsPaused;
            if (GameOver.IsPaused == false)
            {
                SpawnManager.timer = Time.time;
            }
        }
    }

    void OnGUI()
    {
        GUI.skin = skin;

        if (GameOver.IsPaused || GameOver.IsGameOver)
        {
            Cursor.visible = true;
            if (GUI.Button(new Rect(Screen.width / 2 - 100, 215, 200, 35), "Restart Game"))
            {
                CameraMovement.speed = -25;
                CarControl_Left.speed = -25;
                CarControl_Right.speed = -25;
                Score.score = 0;
                Application.LoadLevel(1);
            }

            if (GUI.Button(new Rect(Screen.width / 2 - 100, 255, 200, 35), "Main Menu"))
            {
				CameraMovement.speed = -25;
				CarControl_Left.speed = -25;
				CarControl_Right.speed = -25;
				Score.score = 0;
                Application.LoadLevel(0);
            }
        }
        else
            Cursor.visible = false;
    }
}
