using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.UI;
using Assets.Scripts.Upgrade;
using UnityEngine;

public class ShopWindow : UIWindow
{

    public UpgradeController UpgradeController;

    public override void OnOpen()
    {
        print("on open");
        UpgradeController.UpdateViews();
        base.OnOpen();
    }
}
