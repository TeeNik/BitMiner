using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeElementModel {

    public string Title;
    public int Level;
    public double Price;
    public double Speed;

    public UpgradeElementModel()
    {

    }

    public UpgradeElementModel(string title, int level, double price, double speed)
    {
        Title = title;
        Level = level;
        Price = price;
        Speed = speed;
    }

}
