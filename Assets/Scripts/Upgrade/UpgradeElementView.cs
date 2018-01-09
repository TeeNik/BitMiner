using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeElementView : MonoBehaviour {

    public Image Avatar;
    public Text Title;
    public Text Price;
    public Text Level;
    public Text Speed;

    private UpgradeElementModel _model;

    public void Init(UpgradeElementModel model)
    {
        _model = model;

        Title.text = _model.Title;
        Price.text = _model.Price.ToString();
        Level.text = "Уровень:  " + _model.Level;
        Speed.text = "BPS:  " + _model.Speed;
    }

}
