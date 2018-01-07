using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ResourceManager : MonoBehaviour {

    public static ResourceManager Instance;

    public Image[] UpgradeIcons;
    public TextAsset UpgradeData;


    private void Start()
    {
        Instance = this;
    }

    public static Image GetUpgradeIcons(string name)
    {
        return Get(name + " (UnityEngine.GameObject)", Instance.UpgradeIcons);
    }

    public static T Get<T>(string name, T[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].ToString() == name)
            {
                return array[i];
            }
        }
        return default(T);
    }

}
