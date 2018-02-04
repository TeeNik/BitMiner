using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Upgrade;
using UnityEngine;

public class ShopWindow : UIWindow
{

    public UpgradeController UpgradeController;

    void OnOpen()
    {
        UpgradeController.UpdateViews();
    }
}
