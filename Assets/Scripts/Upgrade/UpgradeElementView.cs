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
    public Button Button;

    private UpgradeElementModel _model;

    public void Init(UpgradeElementModel model)
    {
        _model = model;

        Title.text = _model.Title;
        Price.text = Tools.DoubleToString(_model.Price);
        Level.text = "Уровень:  " + _model.Level;
        Speed.text = "BPS:  " + Tools.DoubleToString(_model.Speed);
    }

    public void SetEnabled(bool enable)
    {
        Button.interactable = enable;
        int gr = enable ? 0 : 1;
        Avatar.material.SetFloat("_GrayscaleAmount", gr);
    }

    /*private void setButtonEnabled(Button button, int gr)
    {
        Material mat = Instantiate(button.GetComponent<Image>().material);
        mat.SetFloat("_GrayscaleAmount", gr); //1==gray
        button.GetComponent<Image>().material = mat;
    }*/

}
