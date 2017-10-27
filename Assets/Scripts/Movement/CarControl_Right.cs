﻿using UnityEngine;
using System.Collections;

public class CarControl_Right : MonoBehaviour {

    public static float speed = -25;
	
	void Update () {
        if (GameOver.IsGameOver == false && GameOver.IsPaused == false)
        {
            GetComponent<AudioSource>().enabled = true;
            if (Score.score > 10)
                speed = -28;
            if (Score.score > 20)
                speed = -33;
            if (Score.score > 30)
                speed = -36;
            if (Score.score > 40)
                speed = -40;
            transform.position += new Vector3(0, 0, speed * Time.deltaTime);
            if (Input.GetKeyDown("left") && transform.position.x < -10)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
                transform.position = new Vector3(-11.2f, transform.position.y, transform.position.z);
                iTween.RotateBy(gameObject, iTween.Hash("y", -.03, "easeType", "easeInOutBack", "time", 0.1));
                iTween.MoveBy(gameObject, iTween.Hash("x", -4, "z", 0.8, "easeType", "easeInOutExpo", "time", 0.2));
                iTween.RotateBy(gameObject, iTween.Hash("y", .03, "easeType", "easeInOutBack", "time", 0.1, "delay", 0.1));
            }
            if (Input.GetKeyDown("right") && transform.position.x > -10)
            {
                transform.rotation = new Quaternion(0, 180, 0, 0);
                transform.position = new Vector3(-7.2f, transform.position.y, transform.position.z);
                iTween.RotateBy(gameObject, iTween.Hash("y", .03, "easeType", "easeInOutBack", "time", 0.1));
                iTween.MoveBy(gameObject, iTween.Hash("x", 4, "z", 0.8, "easeType", "easeInOutExpo", "time", 0.2));
                iTween.RotateBy(gameObject, iTween.Hash("y", -.03, "easeType", "easeInOutBack", "time", 0.1, "delay", 0.1));
            }
        }
        else
        {
            GetComponent<AudioSource>().enabled = false;
        }
	}
}
