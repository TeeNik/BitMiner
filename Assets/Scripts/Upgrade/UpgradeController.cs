using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

namespace Assets.Scripts.Upgrade
{
    public class UpgradeController : MonoBehaviour
    {

        public UpgradeElementView upgradeView;

        public Transform Data;

        public static event Action<double> InitAutoMine;

        void Start()
        {
            Init();
        }

        void Init()
        {
            double score = 0.00000002;

            List<UpgradeElementModel> models = JsonConvert.DeserializeObject<List<UpgradeElementModel>>(ResourceManager.Instance.UpgradeData.text);
            foreach (UpgradeElementModel model in models)
            {
                var clone = Instantiate(upgradeView, Data);
                clone.Init(model);
            }
            InitAutoMine(score);

        }
    }
}
