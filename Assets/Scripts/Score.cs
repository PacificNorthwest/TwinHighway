using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

    public Text ScoreText;
    public Text HighscoreText;
    public static int score;
    private int highscore;

	// Use this for initialization
	void Start () {
        highscore = PlayerPrefs.GetInt("Highscore");
    }
	
	// Update is called once per frame
	void Update () {
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("Highscore", highscore);
        }
        ScoreText.text = "Score: " + score.ToString();
        HighscoreText.text = "Highscore: " + highscore.ToString();
	}
}
