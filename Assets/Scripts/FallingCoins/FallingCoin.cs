using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FallingCoin : MonoBehaviour {

    private float _speed;
    private bool _active;
    public Image self;

    public void Start()
    {
        _speed = Random.Range(15, 20);
        self.rectTransform.DOAnchorPosY(-1600, _speed);
    }

    public void StartMoving()
    {
        gameObject.SetActive(true);
        _speed = Random.Range(3, 5);
        self.rectTransform.DOAnchorPosY(-1600, _speed);
    }

    public void StopMoving()
    {
        DOTween.Kill(self.rectTransform);
        transform.localPosition = new Vector3(transform.localPosition.x, 0, 0);
        gameObject.SetActive(false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Finish")
        {
            StopMoving();
        }
    }
}
