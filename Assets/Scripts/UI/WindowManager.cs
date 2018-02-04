using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.UI;
using DG.Tweening;
using UnityEngine;

public class WindowManager : MonoBehaviour {

    public static WindowManager Instance;

    private float _lastPos;
    private UIWindow _openedWindow;

    public GameObject Background;

    public UIWindow[] Windows;

    void Start()
    {
        Instance = this;
    }

    public void OpenWindow(UIWindow.WindowType type)
    {        
        _openedWindow = GetWindow(type);    
        _openedWindow.OnOpen();
        Background.SetActive(true);
    }

    public void CloseWindow()
    {
        _openedWindow.OnClose();
        _openedWindow = null;        
        Background.SetActive(false);
    }

    public UIWindow GetWindow(UIWindow.WindowType type)
    {
        foreach (UIWindow window in Windows)
        {
            if (window.Type == type)
                return window;
        }

        throw new Exception("There is no window of type = " + type);
    }

}
