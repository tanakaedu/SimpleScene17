using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameParams : MonoBehaviour {
    /** 自分のインスタンス*/
    public static GameParams _instance;
    /** スコアを表示するテキスト*/
    public Text ScoreText;
    /** スコア*/
    public static int Score = 0;

	// Use this for initialization
	void Start () {
        _instance = this;
    }

    public static void SetScore(int sc)
    {
        Score= sc;
        DrawScore();
    }

    public static void AddScore(int add)
    {
        Score += add;
        DrawScore();
    }

    public static void DrawScore()
    {
        _instance.ScoreText.text = "Score " + Score.ToString("D6");
    }	
}
