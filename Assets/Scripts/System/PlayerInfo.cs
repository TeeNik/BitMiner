using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInfo : MonoBehaviour {

    private double _score;
    private int _combo;

    public Text ScoreText;

    public void Start()
    {
        _score = PlayerPrefs.GetFloat("score");
        MineClick.Mine += Click;
        AutoMine.Mine += Click;
        _combo = 0;
    }

    public void Click(double value)
    {
        _score += value;
        ScoreText.text = String.Format("{0:F8}", _score);
    }
    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("score", (float)_score);
    }
}
