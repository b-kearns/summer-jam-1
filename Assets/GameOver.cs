using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System;

public class GameOver : MonoBehaviour
{
    public GameObject scoreUI;
    public GameObject gameOverUI;

    public void OnCrash()
    {
        scoreUI.SetActive(false);
        gameOverUI.SetActive(true);
    } 
}
