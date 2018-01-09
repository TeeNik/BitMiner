using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MenuButton : MonoBehaviour
{

    public Transform Window;
    public void OnClick()
    {
        Window.DOLocalMoveX(0, 1);
    }
}
