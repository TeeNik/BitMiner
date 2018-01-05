using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class UpgradeController : MonoBehaviour
{

    public UpgradeElementView upgradeView;

    public static event Action<double> InitAutoMine;

    void Start()
    {
        Init();
    }

    void Init()
    {
        double score = 1.5;
        //instanciate of upgrade view with models

        InitAutoMine(score);

    }
}
