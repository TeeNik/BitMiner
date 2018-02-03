using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WindowManager : MonoBehaviour {

    public static WindowManager Instance;

    private float _lastPos;
    private Transform _openedWindow;

    public GameObject Background;

    void Start()
    {
        Instance = this;
    }

    public void OpenWindow(Transform window)
    {
        _openedWindow = window;
        _lastPos =  window.localPosition.x;
        GetComponent<RectTransform>().DOAnchorPosX(-300, 1);
        Background.SetActive(true);
    }

    public void CloseWindow()
    {
        _openedWindow.DOLocalMoveX(_lastPos, 1);
        _openedWindow = null;
        Background.SetActive(false);
    }

}
