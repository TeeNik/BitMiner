using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WindowManager : MonoBehaviour {

    public static WindowManager Instance;

    private float _lastPos;
    private RectTransform _openedWindow;

    public GameObject Background;

    public UIWindow[] Windows;

    void Start()
    {
        Instance = this;
    }

    public void OpenWindow(UIWindow.WindowType window)
    {
        window.gameObject.SetActive(true);
        _openedWindow = window;
        _lastPos = window.localPosition.x;
        window.DOAnchorPosX(-300, 1);
        Background.SetActive(true);
    }

    public void CloseWindow()
    {
        _openedWindow.DOLocalMoveX(_lastPos, 1).OnComplete(() => { _openedWindow.gameObject.SetActive(false); });
        _openedWindow = null;
        Background.SetActive(false);
    }

}
