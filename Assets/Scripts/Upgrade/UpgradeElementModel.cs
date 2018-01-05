using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeElementModel {

    public string Title;
    public int Level;
    public int Price;
    public float Speed;

    public UpgradeElementModel()
    {

    }

    public UpgradeElementModel(string title, int level, int price, float speed)
    {
        Title = title;
        Level = level;
        Price = price;
        Speed = speed;
    }

}
