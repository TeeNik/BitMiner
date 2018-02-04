using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIWindow : MonoBehaviour{

    public enum WindowType
    {
        Shop
    }

    public WindowType Type;
    public RectTransform RectTransform;

    private float _lastPos;

    public void OnOpen()
    {
        gameObject.SetActive(true);
        _lastPos = RectTransform.localPosition.x;
        RectTransform.DOAnchorPosX(-300, 1);
    }

    public void OnClose()
    {
        RectTransform.DOLocalMoveX(_lastPos, 1).OnComplete(() => { gameObject.SetActive(false); });
    }
}

