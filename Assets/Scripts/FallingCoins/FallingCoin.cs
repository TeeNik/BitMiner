using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingCoin : MonoBehaviour {

    private float _speed;
    private bool _active;

    void Start()
    {
        _speed = Random.Range(1, 3);
    }

	void Update () {
        if(_active)
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
	}

    public void StartMoving()
    {
        gameObject.SetActive(true);
        _active = true;
    }

    public void StopMoving()
    {
        _active = false;
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
