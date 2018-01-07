using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Newtonsoft.Json;

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


        List<UpgradeElementModel> models = JsonConvert.DeserializeObject<List<UpgradeElementModel>>(ResourceManager.Instance.UpgradeData.text);
        foreach (UpgradeElementModel model in models)
        {
            print(model.Title);
        }
        InitAutoMine(score);

    }
}
