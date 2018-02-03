using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    private List<FallingCoin> _coinPool = new List<FallingCoin>();
   
    public FallingCoin Coin;
    public int SizeOfCoins = 200;
    private int _coinCount = 0;
    
    void Start()
    {
        GenerateCoinPool();
        MineClick.Mine += SpawnCoin;  
    }

    private void GenerateCoinPool()
    {
        for (int i = 0; i < SizeOfCoins; i++)
        {
            var clone = Instantiate(Coin, gameObject.transform, false);
            clone.transform.localPosition = new Vector3(Random.Range(-250f, 250f), 0, 0);
            float scale = Random.Range(0.1f, 0.20f);
            clone.transform.localScale = new Vector3(scale, scale, 1);
            clone.gameObject.SetActive(false);
            _coinPool.Add(clone);
        }
    }

    void SpawnCoin(double d = 0)
    {
        _coinCount = (_coinCount < SizeOfCoins) ? ++_coinCount : 0;
        _coinPool[_coinCount].StartMoving();
    }

    


}
