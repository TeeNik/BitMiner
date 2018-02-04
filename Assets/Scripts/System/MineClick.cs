using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

public class MineClick : MonoBehaviour {

    public static event Action<double> Mine;

    private int _combo = 1;
    private int _clicks = 0;
    private float _timer = 0;

    void FixedUpdate()
    {
        if(Time.time - _timer > 1)
        {
            _timer = Time.time;
            _combo = _clicks / 2;
            _clicks = 0;
        }
    }

    public void ButtonClick()
    {
        //transform.DOPunchScale(new Vector3(0.55f, 0.55f, 1), 0.5f);
        if (Mine != null) Mine(0.00000001 * _combo);
        _clicks++;
    }
}
