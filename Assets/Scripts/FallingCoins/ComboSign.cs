using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboSign : MonoBehaviour
{
    public Text Text;

	public void Activate()
    {
        gameObject.SetActive(true);
        transform.DOLocalMoveX(transform.localPosition.x+20, 1);
        Text.DOFade(0, 1).OnComplete(() =>
        {
            gameObject.SetActive(false);
        });
    }
}
