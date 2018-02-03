using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignSpawner : MonoBehaviour {

    private int _signCount = 0;
    private List<ComboSign> _comboSignPool = new List<ComboSign>();
    public ComboSign ComboSign;
    public int SizeOfSigns = 15;
    void Start () {
	    GenerateComboSignPool();
        MineClick.Mine += SpawnSign;
    }

    private void GenerateComboSignPool()
    {
        for (int i = 0; i < SizeOfSigns; i++)
        {
            var clone = Instantiate(ComboSign, gameObject.transform, false);
            clone.transform.localPosition = new Vector3(Random.Range(300, 600), Random.Range(-300, -600), 0);
            clone.gameObject.SetActive(false);
            _comboSignPool.Add(clone);
        }
    }

    void SpawnSign(double d = 0)
    {
        _signCount = _signCount < SizeOfSigns ? ++_signCount : 0;
        _comboSignPool[_signCount].Activate();
    }
}
