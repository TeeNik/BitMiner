using System;
using System.Collections.Generic;
using System.IO;
using JetBrains.Annotations;
using Newtonsoft.Json;
using UnityEngine;

namespace Assets.Scripts.Upgrade
{
    public class UpgradeController : MonoBehaviour
    {
        public UpgradeElementView upgradeView;
        private List<UpgradeElementView> _views;

        public Transform Data;

        public static event Action<double> InitAutoMine;

        private string gameDataProjectFilePath = "/StreamingAssets/data.json";

        void Start()
        {
            UpgradeElementView.Buy += BuyUpgrade;
            _views = new List<UpgradeElementView>();
        }

        public void Init()
        {
            double score = 0.00000002;

            List<UpgradeElementModel> models = LoadGameData();
            foreach (UpgradeElementModel model in models)
            {
                var clone = Instantiate(upgradeView, Data);
                clone.Init(model);
                _views.Add(clone);
            }

            if (InitAutoMine != null) InitAutoMine(score);
            UpdateViews();
        }

        public void UpdateViews()
        {
            bool unknown = false;
            double score = StaticManager.GetPlayer().GetScore();
            print(_views);
            foreach (UpgradeElementView view in _views)
            {
                if (unknown)
                    view.SetUnknown();
                else
                    view.SetEnabled(score >= view.Model.Price);
                

                if (view.Model.Level == 0) unknown = true;
            }
        }

        public void BuyUpgrade(int id)
        {
            if (StaticManager.GetPlayer().SpendScore(_views[id].Model.Price))
            {
                var view = _views[id];
                view.Model.Level++;
                view.Model.Price *= 1.5;
                view.Init(view.Model);
                UpdateViews();
            }                
        }

        private List<UpgradeElementModel> LoadGameData()
        {
            string filePath = Application.dataPath + gameDataProjectFilePath;
            if (File.Exists(filePath))
            {
                return JsonConvert.DeserializeObject<List<UpgradeElementModel>>(File.ReadAllText(filePath));;
            }

            return JsonConvert.DeserializeObject<List<UpgradeElementModel>>(ResourceManager.Instance.UpgradeData.text);
        }

        void SaveGameData()
        {
            List<UpgradeElementModel> models = new List<UpgradeElementModel>();
            foreach (var view in _views)
            {
                models.Add(view.Model);
            }
            string data = JsonConvert.SerializeObject(models);
            string filePath = Application.dataPath + gameDataProjectFilePath;
            File.WriteAllText(filePath, data);
        }

        void OnApplicationQuit()
        {
            //SaveGameData();
        }

    }
}
