using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    public UIWindow.WindowType Window;
    public void OnClickOpen()
    {
        WindowManager.Instance.OpenWindow(Window);
    }

    public void OnClickClose()
    {
        WindowManager.Instance.CloseWindow();
    }
}
