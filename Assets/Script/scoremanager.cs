using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    public static scoremanager instance;

    public int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void AddScore(int value)
    {
        score += value;
    }
}
