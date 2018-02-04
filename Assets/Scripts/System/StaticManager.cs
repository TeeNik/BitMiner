using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticManager : MonoBehaviour
{
    public static StaticManager Instance;

    public PlayerInfo Player;

    void Start()
    {
        Instance = this;
    }

    public static PlayerInfo GetPlayer()
    {
        return Instance.Player;
    }
}
