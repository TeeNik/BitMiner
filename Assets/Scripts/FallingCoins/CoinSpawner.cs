using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    private List<FallingCoin> _coinPool = new List<FallingCoin>();
    private List<ComboSign> _comboSignPool = new List<ComboSign>();
    
    public FallingCoin Coin;
    public ComboSign ComboSign;
    public int SizeOfCoins = 200;
    private int count = 0;

    void Start()
    {
        GenerateCoinPool();
        GenerateComboSignPool();

        MineClick.Mine += SpawnCoin;
    }

    private void GenerateCoinPool()
    {
        for (int i = 0; i < SizeOfCoins; i++)
        {
            var clone = Instantiate(Coin, gameObject.transform, false);
            clone.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0, 0);
            float scale = Random.Range(0.1f, 0.20f);
            clone.transform.localScale = new Vector3(scale, scale, 1);
            clone.gameObject.SetActive(false);
            _coinPool.Add(clone);
        }
    }

    private void GenerateComboSignPool()
    {
        var clone = Instantiate(ComboSign, gameObject.transform, false);
        clone.transform.localPosition = new Vector3(Random.Range(-2f, 2f), 0, 0);
        clone.gameObject.SetActive(false);
        _comboSignPool.Add(clone);
    }


    void SpawnCoin(double d = 0)
    {
        count = (count < SizeOfCoins) ? ++count : 0;
        _coinPool[count].StartMoving();
    }


}
