using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Timers;
using Assets.Scripts.Upgrade;

public class AutoMine : MonoBehaviour {

    private double _score = 0.00000002;

    private Timer _timer;

    public static event Action<double> Mine;

    void Start()
    {
        UpgradeController.InitAutoMine += Init;
    }

    void Init(double score)
    {
        _score = score;
        StartCoroutine(Execute());
    }

    IEnumerator Execute()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            Mine(_score);
        }
    }

}
