using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

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
        Mine(1*_combo);
        _clicks++;
    }
}
