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
        transform.DOLocalMoveY(transform.localPosition.y+100, 1);
        Text.DOFade(0, 1).OnComplete(() =>
        {
            transform.DOLocalMoveY(transform.localPosition.y - 100, 0.1f);
            Text.DOFade(1, 0.1f);
            gameObject.SetActive(false);
        });
    }
}
