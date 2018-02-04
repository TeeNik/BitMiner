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
        UpdateText();
    }

    private void UpdateText()
    {
        ScoreText.text = Tools.DoubleToString(_score);
    }

    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("score", (float)_score);
    }

    public double GetScore()
    {
        return _score;
    }

    public bool SpendScore(double value)
    {
        if (value >= _score)
        {
            _score -= value;
            UpdateText();
            return true;
        }

        return false;
    }
}
