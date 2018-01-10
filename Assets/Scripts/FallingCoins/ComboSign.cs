using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComboSign : MonoBehaviour {

	public void Activate()
    {
        gameObject.SetActive(true);
        transform.DOLocalMoveX(20, 1);
        Color color = GetComponent<Text>().color;
        DOTween.To(() => color.a, x => color.a = x, 0, 1);
    }
}
