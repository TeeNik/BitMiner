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

    public UpgradeElementModel Model;

    public void Init(UpgradeElementModel model)
    {
        Model = model;

        Title.text = Model.Title;
        Price.text = Tools.DoubleToString(Model.Price);
        Level.text = "Уровень:  " + Model.Level;
        Speed.text = "BPS:  " + Tools.DoubleToString(Model.Speed);
    }

    public void SetEnabled(bool enable)
    {
        Button.interactable = enable;
        int gr = enable ? 0 : 1;
        Avatar.material.SetFloat("_GrayscaleAmount", gr);
    }

    public void SetUnknown()
    {
        Title.text = "????????";
        Price.text = "????????";
        Level.text = "Уровень:  " + 0;
        Speed.text = "BPS:  " + "????";
        Avatar.color = Color.black;
    }

    /*private void setButtonEnabled(Button button, int gr)
    {
        Material mat = Instantiate(button.GetComponent<Image>().material);
        mat.SetFloat("_GrayscaleAmount", gr); //1==gray
        button.GetComponent<Image>().material = mat;
    }*/

}
