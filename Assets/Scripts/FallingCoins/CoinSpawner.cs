using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    private List<FallingCoin> _coinPool = new List<FallingCoin>();
    public FallingCoin Coin;
    public int Size = 200;
    private int count = 0;

    void Start()
    {
        for(int i = 0; i < Size; i++)
        {
            var clone = Instantiate(Coin, gameObject.transform, false);
            clone.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0, 0);
            float scale = Random.Range(0.45f, 0.75f);
            clone.transform.localScale = new Vector3(scale, scale, 1);
            clone.gameObject.SetActive(false);
            _coinPool.Add(clone);
        }

        MineClick.Mine += Spawn;
    }

    void Spawn(double d = 0)
    {
        count = (count < Size) ? ++count : 0;
        _coinPool[count].StartMoving();
    }


}
