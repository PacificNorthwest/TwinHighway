using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour
{
    public GUISkin skin;

    void Start()
    {
        Application.targetFrameRate = 60;
        Cursor.visible = true;
    }

    void Update()
    {
            transform.position += new Vector3(0, 0, -10 * Time.deltaTime);
    }

    void OnGUI()
    {
        GUI.skin = skin;

        if (GUI.Button(new Rect(Screen.width / 2 - 100, 235, 200, 35), "Start Game"))
        {
            Application.LoadLevel(1);
        }

        if (GUI.Button(new Rect(Screen.width / 2 - 100, 275, 200, 35), "Quit"))
        {
            Application.Quit();
        }
    }
}
