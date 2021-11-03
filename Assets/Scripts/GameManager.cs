using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public Transform Player;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}
