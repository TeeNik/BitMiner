using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WindowManager : MonoBehaviour {

    public static WindowManager Instance;

    private float _lastPos;

    public void OpenWindow(Transform window)
    {
        _lastPos =  window.localPosition.x;
        window.DOLocalMoveX(0, 1);
    }

    public void CloseWindow(Transform window)
    {
        window.DOLocalMoveX(_lastPos, 1);
    }

}
