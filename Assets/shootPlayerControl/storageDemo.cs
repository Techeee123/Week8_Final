using System;
using UnityEngine;

public class storageDemo : MonoBehaviour
{
    private void Start()
    {
        Debug.Log(PlayerPrefs.GetInt("Coin"));
    }
}
